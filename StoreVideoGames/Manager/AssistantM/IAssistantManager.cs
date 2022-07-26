using EFDataAccess.Models;
using StoreVideoGames.DTOs.AssistantDTOs;

namespace StoreVideoGames.Manager.AssistantM
{
    public interface IAssistantManager
    {
        Task<ManagerResult<Assistant>> AddAsync(CreateAssistantDTO createAssistantDTO);
        Task<ManagerResult<Assistant>> GetAsync();
        Task<ManagerResult<Assistant>> UpdateAsync(int id, CreateAssistantDTO updateAssistantDTO);
        Task<ManagerResult<Assistant>> DeleteAsync(int id);
    }
}
