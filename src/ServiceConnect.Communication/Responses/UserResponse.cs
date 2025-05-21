using ServiceConnect.Communication.Enums;

namespace ServiceConnect.Communication.Responses;
public class UserResponse
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserType Role { get; set; }
}
