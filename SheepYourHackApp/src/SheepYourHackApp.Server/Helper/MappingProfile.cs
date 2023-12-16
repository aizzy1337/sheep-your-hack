using AutoMapper;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Models.DTO;

namespace SheepYourHackApp.Server.Helper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<Event, EventDto>();
        CreateMap<Option, OptionDto>();
        CreateMap<Poll, PollDto>();
        CreateMap<Feed, FeedDto>()
            .ForMember(dest => dest.UserNickName, opt => opt.MapFrom(src => src.User.Nickname))
            .ForMember(dest => dest.Event, opt => opt.MapFrom(src => src.Event))
            .ForMember(dest => dest.Poll, opt => opt.MapFrom(src => src.Poll));
        CreateMap<Group, GroupDto>();
    }
}
