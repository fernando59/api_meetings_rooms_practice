using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.AssistantDTOs;

namespace StoreVideoGames.AutoMapper
{
    public class AssistantProfile:Profile
    {
        public AssistantProfile()
        {
            CreateMap<CreateAssistantDTO,Assistant>();
        }
    }
}
