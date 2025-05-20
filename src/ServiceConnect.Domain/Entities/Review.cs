namespace ServiceConnect.Domain.Entities;
public class Review
{
    public Guid Id { get; set; }
    public Guid ServiceId { get; set; }
    public Guid CustomerId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
