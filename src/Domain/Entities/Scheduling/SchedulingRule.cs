namespace Domain.Entities.Scheduling;

public class SchedulingRule : BaseEntity
{
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    public string KeyRule { get; set; }
    public string ValueKeyRule { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}