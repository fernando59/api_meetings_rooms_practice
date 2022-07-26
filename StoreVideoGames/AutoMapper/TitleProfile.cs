using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.TitleDTOs;

namespace StoreVideoGames.AutoMapper
{
    public class TitleProfile:Profile
    {

        public TitleProfile()
        {
            CreateMap<CreateTitleDTO,Title>();
        }
    }
}
