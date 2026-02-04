namespace Domain.Entities.Core;

public class Product : BaseEntity
{
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public float? Discount { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

}