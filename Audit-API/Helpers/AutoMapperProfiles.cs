using Audit_API.DTOs;
using Audit_API.Models;
using AutoMapper;

namespace Audit_API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserForRegisterDto, User>();
            CreateMap<UserForDetailDto, User>();
        }
    }
}