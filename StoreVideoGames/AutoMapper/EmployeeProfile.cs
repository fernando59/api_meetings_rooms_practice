using AutoMapper;
using EFDataAccess.Models;
using StoreVideoGames.DTOs.EmployeeDTOs;

namespace StoreVideoGames.AutoMapper
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeDTO,Employee>();
        }
    }
}
