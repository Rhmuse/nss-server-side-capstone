namespace KrustyKrab.Models;

public class OrderSide
{
    public Guid Id { get; set; }
    public Guid SideId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public Guid SizeId { get; set; }
    public bool IsInCombo { get; set; } = false;
    public Guid? OrderComboId { get; set; }
    public Side? Side { get; set; }
    public Order? Order { get; set; }
}