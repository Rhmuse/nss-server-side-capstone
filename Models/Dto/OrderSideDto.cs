namespace KrustyKrab.Models;

public class OrderSideDto
{
    public Guid SideId { get; set; }
    public int Quantity { get; set; }
    public Guid SizeId { get; set; }
}