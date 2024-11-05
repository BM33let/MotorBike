using AutoMapper;
using DIRTBIKESBM.Dto;
using DIRTBIKESBM.Models;

namespace DIRTBIKESBM.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Motor, MotorDto>();
        }
    }
}
