using ServiceConnect.Domain.Enums;

namespace ServiceConnect.Domain.Entities;

public class Service
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public CategoryService Category { get; set; }
    public decimal Price { get; set; }
    public Guid ProviderId { get; set; }
    public DateTime CreatedAt { get; set; }
}

