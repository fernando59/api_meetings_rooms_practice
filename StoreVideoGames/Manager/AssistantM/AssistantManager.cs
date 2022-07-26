using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.AssistantDTOs;
using StoreVideoGames.Repositories.AssistantRepository;

namespace StoreVideoGames.Manager.AssistantM
{
    public class AssistantManager : IAssistantManager
    {
        private readonly IAssistantRepository _repository;
        private readonly IMapper _mapper;

        public AssistantManager(IAssistantRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<ManagerResult<Assistant>> AddAsync(CreateAssistantDTO createAssistantDTO)
        {
            var managerResult = new ManagerResult<Assistant>();
            try
            {
                var entity = _mapper.Map<Assistant>(createAssistantDTO);
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

        public async Task<ManagerResult<Assistant>> DeleteAsync(int id)
        {
            var managerResult = new ManagerResult<Assistant>();
            var AssistantEntity = await _repository.GetByIdAsync(id);
            if (AssistantEntity == null)
            {
                managerResult.Success = false;
                managerResult.Message = "Not exist Assistant";
                return managerResult;
            }

            var entity = _mapper.Map<Assistant>(AssistantEntity);
            await _repository.DeleteAsync(entity);
            managerResult.Message = "Delete Successfully";
            return managerResult;
        }

        public async Task<ManagerResult<Assistant>> GetAsync()
        {
            var managerResult = new ManagerResult<Assistant>();
            managerResult.Data = await _repository.GetAllAsync();
            return managerResult;
        }

        public async Task<ManagerResult<Assistant>> UpdateAsync(int id, CreateAssistantDTO updateAssistantDTO)
        {
            var managerResult = new ManagerResult<Assistant>();
            try
            {
                var AssistantEntity = await _repository.GetByIdAsync(id);

                if (AssistantEntity == null)
                {
                    managerResult.Success = false;
                    managerResult.Message = "Not exist Assistant";
                    return managerResult;
                }
                AssistantEntity.isAttend = updateAssistantDTO.isAttend;
                AssistantEntity.ReservationId = updateAssistantDTO.reservationId;

                //var entity = _mapper.Map<Assistant>(updateAssistantDTO);
                await _repository.UpdateAsync(AssistantEntity);
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
