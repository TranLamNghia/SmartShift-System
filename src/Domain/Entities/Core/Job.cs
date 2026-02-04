namespace Domain.Entities.Core;

using Domain.Enums;
using Domain.Entities.Forecast;

public class Job : BaseEntity
{
    public NameJob NameJob { get; set; }
    public string Description { get; set; }
    public ICollection<RoleStaff> RoleStaffs { get; set; }
    public ICollection<DemandForeCast> DemandForeCasts { get; set; }
}