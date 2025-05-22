using AutoMapper;
using ServiceConnect.Communication.Requests;
using ServiceConnect.Communication.Responses;
using ServiceConnect.Domain.Entities;

namespace ServiceConnect.Application.AutoMapper;
public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, UserResponse>();
    }
}
