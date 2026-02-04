namespace Domain.Entities.Core;

public class Order : BaseEntity
{
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}