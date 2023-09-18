using Business.Models.Request;
using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using System.Runtime.CompilerServices;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        //Users
        CreateMap<RegisterDto, User>();       
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, UserProfileDto>();

        //Events
        CreateMap<CreateEventDto, Event>();
        CreateMap<EventUpdateDto, Event>();
        CreateMap<Event, EventInfoDto>();

        //Comments
        CreateMap<CreateCommentDto, Comment>();
        CreateMap<CommentUpdate,Comment>();
        CreateMap<Comment, CommentInfoDto>();

        //CommentLikes
        CreateMap<CreateCommentLikeDto, CommentLike>();
        CreateMap<CommentLike, CommentLikeInfoDto>();

        //EventParticipants
        CreateMap<CreateEventParticipantDto,EventParticipant>();
        CreateMap<EventParticipant,EventParticipantInfoDto>();

        //Categories
        CreateMap<CreateCategoryDto, Category>();
        CreateMap<CategoryUpdateDto,Category>();
        CreateMap<Category,CategoryInfoDto>();

        


    }
}