using AutoMapper;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Models.DTO;

namespace SheepYourHackApp.Server.Helper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
        CreateMap<Event, EventDto>();
        CreateMap<EventDto, Event>();
        CreateMap<Option, OptionDto>();
        CreateMap<OptionDto, Option>();
        CreateMap<Poll, PollDto>();
        CreateMap<PollDto, Poll>();
        CreateMap<Feed, FeedDto>()
            .ForMember(dest => dest.UserNickName, opt => opt.MapFrom(src => src.User.Nickname))
            .ForMember(dest => dest.Event, opt => opt.MapFrom(src => src.Event))
            .ForMember(dest => dest.Poll, opt => opt.MapFrom(src => src.Poll))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id));
        CreateMap<Group, GroupDto>();
        CreateMap<FeedDto, Feed>();
    }
}
