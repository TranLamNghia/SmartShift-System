namespace Domain.Entities.Forecast;

public class DemandForecast : BaseEntity
{
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    public Guid JobId { get; set; }
    public Job Job { get; set; }
    public int ShiftDefinitionId { get; set; }
    public ShiftDefinition ShiftDefinition { get; set; }
    public DateTime Date { get; set; }
    public int RequiredStaffCount { get; set; }
    public DateTime CreatedAt { get; set; }
}