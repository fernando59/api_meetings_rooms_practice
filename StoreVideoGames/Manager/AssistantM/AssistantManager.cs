using EFDataAccess.Models;
using StoreVideoGames.DTOs.AssistantDTOs;

namespace StoreVideoGames.Manager.AssistantM
{
    public class AssistantManager : IAssistantManager
    {
        public Task<ManagerResult<Assistant>> AddAsync(CreateAssistantDTO createAssistantDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Assistant>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Assistant>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Assistant>> UpdateAsync(int id, CreateAssistantDTO updateAssistantDTO)
        {
            throw new NotImplementedException();
        }
    }
}
