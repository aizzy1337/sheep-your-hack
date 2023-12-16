using AutoMapper;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Models.DTO;

namespace SheepYourHackApp.Server.Helper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<Feed, FeedDto>()
            .ForMember(dest => dest.UserNickName, opt => opt.MapFrom(src => src.User.Nickname))
            .ForMember(dest => dest.EventId, opt => opt.MapFrom(src => src.Event.Id));
        CreateMap<Group, GroupDto>();
        CreateMap<FeedDto, Feed>();
    }
}
