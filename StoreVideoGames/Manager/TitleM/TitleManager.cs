using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.TitleDTOs;
using StoreVideoGames.Repositories;
using StoreVideoGames.Repositories.TitleRepository;

namespace StoreVideoGames.Manager.TitleM
{
    public class TitleManager : ITitleManager
    {
        private readonly ITitleRepository _repository;
        private readonly IMapper _mapper;

        public TitleManager(ITitleRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ManagerResult<Title>> AddAsync(CreateTitleDTO createTitleDTO)
        {
            var managerResult = new ManagerResult<Title>();
            try
            {
                var entity = _mapper.Map<Title>(createTitleDTO);
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

        public async Task<ManagerResult<Title>> DeleteAsync(int id)
        {
            var managerResult = new ManagerResult<Title>();
            var titleEntity = await _repository.GetByIdAsync(id);
            if (titleEntity == null)
            {
                managerResult.Success = false;
                managerResult.Message = "Not exist Title";
                return managerResult;
            }

            var entity = _mapper.Map<Title>(titleEntity);
            await _repository.DeleteAsync(entity);
            managerResult.Message = "Delete Successfully";
            return managerResult;
        }

        public async Task<ManagerResult<Title>> GetAsync()
        {
            var managerResult = new ManagerResult<Title>();
            managerResult.Data = await _repository.GetAllAsync();
            return managerResult;
        }

        public async Task<ManagerResult<Title>> UpdateAsync(int id, CreateTitleDTO updateTitleDTO)
        {
            var managerResult = new ManagerResult<Title>();
            try
            {
                var titleEntity = await _repository.GetByIdAsync(id);

                if (titleEntity == null)
                {
                    managerResult.Success = false;
                    managerResult.Message = "Not exist Title";
                    return managerResult;
                }
                titleEntity.platforms = updateTitleDTO.platforms;
                titleEntity.description= updateTitleDTO.description;
                titleEntity.releaseDate= updateTitleDTO.releaseDate;
                titleEntity.released= updateTitleDTO.released;
                titleEntity.name= updateTitleDTO.name;
                titleEntity.developer= updateTitleDTO.developer;
                
                //var entity = _mapper.Map<Title>(updateTitleDTO);
                await _repository.UpdateAsync(titleEntity);
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
