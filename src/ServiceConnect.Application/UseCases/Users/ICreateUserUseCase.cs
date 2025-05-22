using ServiceConnect.Communication.Requests;
using ServiceConnect.Communication.Responses;

namespace ServiceConnect.Application.UseCases.Users;
public interface ICreateUserUseCase
{
    Task<UserResponse> ExecuteAsync(CreateUserRequest request);
}
