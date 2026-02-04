namespace Domain.Entities.Core;

using Domain.Entities.Forecast;

public class ShiftDefinition
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<EmployeeUnavailableSlot> EmployeeUnavailableSlots { get; set; }
    public ICollection<DemandForeCast> DemandForeCasts { get; set; }
}