using AutoMapper;
using DateApp.DTOs;
using DateApp.Entities;
using DateApp.Extensions;

namespace DateApp.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser, MemberDto>()
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                src.Photos.FirstOrDefault(x => x.isMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src =>
                src.DateOfBirth.CalculateAge()));
        CreateMap<Photo, PhotoDto>();
    }
}