namespace Domain.Entities.Core;

public class EmployeePerformanceLog : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public EndUser Employee { get; set; }
    public int KarmaScoreLog { get; set; }
    public string Reason { get; set; }
    public DateTime TimeAt { get; set; }
}