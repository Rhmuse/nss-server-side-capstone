using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;

public class OrderSide
{
    public Guid Id { get; set; }
    public Guid SideId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public Guid ComboItemId { get; set; }
    public Guid SizeId { get; set; }
    [NotMapped]
    public Side? Side { get; set; }
    [NotMapped]
    public Order? Order { get; set; }
}