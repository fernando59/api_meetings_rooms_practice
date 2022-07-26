using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.RoomDTOs;
using StoreVideoGames.Repositories.RoomRespository;

namespace StoreVideoGames.Manager.RoomM
{
    public class RoomManager : IRoomManager
    {
        private readonly IRoomRepository _repository;
        private readonly IMapper _mapper;

        public RoomManager(IRoomRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ManagerResult<Room>> AddAsync(CreateRoomDTO createRoomDTO)
        {
            var managerResult = new ManagerResult<Room>();
            try
            {
                var entity = _mapper.Map<Room>(createRoomDTO);
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

        public async Task<ManagerResult<Room>> DeleteAsync(int id)
        {
            var managerResult = new ManagerResult<Room>();
            var RoomEntity = await _repository.GetByIdAsync(id);
            if (RoomEntity == null)
            {
                managerResult.Success = false;
                managerResult.Message = "Not exist Room";
                return managerResult;
            }

            var entity = _mapper.Map<Room>(RoomEntity);
            await _repository.DeleteAsync(entity);
            managerResult.Message = "Delete Successfully";
            return managerResult;
        }

        public async Task<ManagerResult<Room>> GetAsync()
        {
            var managerResult = new ManagerResult<Room>();
            managerResult.Data = await _repository.GetAllAsync();
            return managerResult;
        }

        public async  Task<ManagerResult<Room>> UpdateAsync(int id, CreateRoomDTO updateRoomDTO)
        {
            var managerResult = new ManagerResult<Room>();
            try
            {
                var RoomEntity = await _repository.GetByIdAsync(id);

                if (RoomEntity == null)
                {
                    managerResult.Success = false;
                    managerResult.Message = "Not exist Room";
                    return managerResult;
                }
                RoomEntity.name = updateRoomDTO.name;
                RoomEntity.description = updateRoomDTO.description;
                RoomEntity.capacity = updateRoomDTO.capacity;
                RoomEntity.isEnable = updateRoomDTO.isEnable;

                var entity = _mapper.Map<Room>(updateRoomDTO);
                await _repository.UpdateAsync(RoomEntity);
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
