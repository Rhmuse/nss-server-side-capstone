namespace KrustyKrab.Models;

public class OrderSide
{
    public Guid Id { get; set; }
    public Guid SideId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }

    public Side Side { get; set; }
    public Order Order { get; set; }
}