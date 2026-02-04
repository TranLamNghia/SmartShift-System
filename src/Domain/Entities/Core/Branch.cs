namespace Domain.Entities.Core;

using Domain.Entities.Forecast;

public class Branch : BaseEntity
{
    public string Location { get; set; }
    public string Hotline { get; set; }
    public ICollection<Product> Products { get; set; }
    public ICollection<EndUser> EndUsers { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<SchedulingRule> SchedulingRules { get; set; }
    public ICollection<DemandForeCast> DemandForeCasts { get; set; }
    public ICollection<RevenueForecast> RevenueForecasts { get; set; }

}