namespace Domain.Entities.Core;

using Domain.Enums;

public class ShiftChangeRequest : BaseEntity
{   
    public Guid EmployeeRequestId { get; set; }
    public EndUser EmployeeRequest { get; set; }
    public Guid ScheduleId { get; set; }
    public Schedule Schedule { get; set; }
    public Guid EmployeeReceiverId { get; set; }
    public EndUser EmployeeReceiver { get; set; }
    public ShiftChangeRequestStatus Status { get; set; }
}