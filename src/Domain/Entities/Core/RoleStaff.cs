namespace Domain.Entities.Core;

public class RoleStaff : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public EndUser Employee { get; set; }
    public Guid JobId { get; set; }
    public Job Job { get; set; }
}