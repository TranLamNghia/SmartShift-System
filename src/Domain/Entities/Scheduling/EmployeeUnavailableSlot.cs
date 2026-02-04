namespace Domain.Entities.Scheduling;

public class EmployeeUnavailableSlot : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public EndUser Employee { get; set; }
    public int DateOfWeek { get; set; }
    public int ShiftDefinitionId { get; set; }
    public ShiftDefinition ShiftDefinition { get; set; }
}