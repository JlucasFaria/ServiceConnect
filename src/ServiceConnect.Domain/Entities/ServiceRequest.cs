using ServiceConnect.Domain.Enums;

namespace ServiceConnect.Domain.Entities;

public class ServiceRequest
{
    public Guid Id { get; set; }
    public Guid ServiceId { get; set; }
    public Guid CustomerId { get; set; }
    public ServiceStatus Status { get; set; }
    public DateTime RequestedAt { get; set; }
    public DateTime? AccepetedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
}
