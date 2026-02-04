namespace Domain.Entities.Core;

using Domain.Enums;

public class Schedule : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public EndUser Employee { get; set; }
    public int ShiftDefinitionId { get; set; }    
    public ShiftDefinition ShiftDefinition { get; set; }
    public DateOnly Date { get; set; }
    public ScheduleStatus Status { get; set; }
    public ICollection<ShiftChangeRequest> ShiftChangeRequests { get; set; }
}