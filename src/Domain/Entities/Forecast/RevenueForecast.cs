namespace Domain.Entities.Forecast;

public class RevenueForecast : BaseEntity
{
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    public decimal PredictedRevenue { get; set; }
    public int PredictedOrderCount { get; set; }
    public DateTime CreatedAt { get; set; }
}