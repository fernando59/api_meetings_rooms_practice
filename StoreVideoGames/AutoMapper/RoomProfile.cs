using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.RoomDTOs;

namespace StoreVideoGames.AutoMapper
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<CreateRoomDTO,Room>();
        }
    }
}
