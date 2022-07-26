using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.ReservationDTOs;

namespace StoreVideoGames.AutoMapper
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<CreateReservationDTO,Reservation>();
        }
    }
}
