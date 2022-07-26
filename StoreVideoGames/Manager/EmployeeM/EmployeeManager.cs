using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.EmployeeDTOs;
using StoreVideoGames.Repositories.EmployeeRepository;

namespace StoreVideoGames.Manager.EmployeeM
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeManager(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<ManagerResult<Employee>> AddAsync(CreateEmployeeDTO createEmployeeDTO)
        {
            var managerResult = new ManagerResult<Employee>();
            try
            {
                var entity = _mapper.Map<Employee>(createEmployeeDTO);
                await _repository.AddAsync(entity);
                managerResult.Message = "Add Successfully";
                return managerResult;
            }
            catch (Exception e)
            {
                managerResult.Success = false;
                managerResult.Message = e.Message;
                return managerResult;
            }
        }

        public async  Task<ManagerResult<Employee>> DeleteAsync(int id)
        {
            var managerResult = new ManagerResult<Employee>();
            var EmployeeEntity = await _repository.GetByIdAsync(id);
            if (EmployeeEntity == null)
            {
                managerResult.Success = false;
                managerResult.Message = "Not exist Employee";
                return managerResult;
            }

            var entity = _mapper.Map<Employee>(EmployeeEntity);
            await _repository.DeleteAsync(entity);
            managerResult.Message = "Delete Successfully";
            return managerResult;
        }

        public async Task<ManagerResult<Employee>> GetAsync()
        {
            var managerResult = new ManagerResult<Employee>();
            managerResult.Data = await _repository.GetAllAsync();
            return managerResult;
        }

        public async Task<ManagerResult<Employee>> UpdateAsync(int id, CreateEmployeeDTO updateEmployeeDTO)
        {
            var managerResult = new ManagerResult<Employee>();
            try
            {
                var EmployeeEntity = await _repository.GetByIdAsync(id);

                if (EmployeeEntity == null)
                {
                    managerResult.Success = false;
                    managerResult.Message = "Not exist Employee";
                    return managerResult;
                }
                EmployeeEntity.name = updateEmployeeDTO.position;
                EmployeeEntity.position = updateEmployeeDTO.name;

                var entity = _mapper.Map<Employee>(updateEmployeeDTO);
                await _repository.UpdateAsync(EmployeeEntity);
                managerResult.Message = "Update Successfully";
                return managerResult;
            }
            catch (Exception e)
            {
                managerResult.Success = false;
                managerResult.Message = e.Message;
                return managerResult;
            }
        }
    }
}
