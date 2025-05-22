using AutoMapper;
using ServiceConnect.Communication.Requests;
using ServiceConnect.Communication.Responses;
using ServiceConnect.Domain.Entities;

namespace ServiceConnect.Application.UseCases.Users;
public class CreateUserUseCase : ICreateUserUseCase
{
    private readonly IMapper _mapper;

    public CreateUserUseCase(IMapper mapper)
    {
        _mapper = mapper;
    }


    public async Task<UserResponse> ExecuteAsync(CreateUserRequest request)
    {
        var user = _mapper.Map<User>(request);
        
        user.Id = Guid.NewGuid();
        user.CreatedAt = DateTime.UtcNow;
        user.PasswordHash = "HASH_" + request.Password;

        var response = _mapper.Map<UserResponse>(user);

        return response;
    }
}
