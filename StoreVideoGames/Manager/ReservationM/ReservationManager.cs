using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.ReservationDTOs;
using StoreVideoGames.Repositories.ReservationRepository;

namespace StoreVideoGames.Manager.ReservationM
{
    public class ReservationManager : IReservationManager
    {
        private readonly IReservationRepository _repository;
        private readonly IMapper _mapper;

        public ReservationManager(IReservationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        public async Task<ManagerResult<Reservation>> AddAsync(CreateReservationDTO createReservationDTO)
        {
            var managerResult = new ManagerResult<Reservation>();
            try
            {
                var entity = _mapper.Map<Reservation>(createReservationDTO);
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

        public async Task<ManagerResult<Reservation>> DeleteAsync(int id)
        {
            var managerResult = new ManagerResult<Reservation>();
            var ReservationEntity = await _repository.GetByIdAsync(id);
            if (ReservationEntity == null)
            {
                managerResult.Success = false;
                managerResult.Message = "Not exist Reservation";
                return managerResult;
            }
            var entity = _mapper.Map<Reservation>(ReservationEntity);
            await _repository.DeleteAsync(entity);
            managerResult.Message = "Delete Successfully";
            return managerResult;
        }

        public async Task<ManagerResult<Reservation>> GetAsync()
        {
            var managerResult = new ManagerResult<Reservation>();
            managerResult.Data = await _repository.GetAllAsync();
            return managerResult;
        }

        public async Task<ManagerResult<Reservation>> UpdateAsync(int id, CreateReservationDTO updateReservationDTO)
        {
            var managerResult = new ManagerResult<Reservation>();
            try
            {
                var ReservationEntity = await _repository.GetByIdAsync(id);

                if (ReservationEntity == null)
                {
                    managerResult.Success = false;
                    managerResult.Message = "Not exist Reservation";
                    return managerResult;
                }
                ReservationEntity.date = updateReservationDTO.date;
                ReservationEntity.EmployeeId = updateReservationDTO.employeeId;
                ReservationEntity.RoomId= updateReservationDTO.roomId;
               
                //var entity = _mapper.Map<Reservation>(updateReservationDTO);
                await _repository.UpdateAsync(ReservationEntity);
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
