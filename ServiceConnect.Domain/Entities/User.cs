﻿using ServiceConnect.Domain.Enums;

namespace ServiceConnect.Domain.Entities;
public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash {  get; set; } = string.Empty;
    public UserType Role { get; set; } 
    public DateTime CreatedAt { get; set; }
}
