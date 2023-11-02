namespace KrustyKrab.Models;

public class OrderSide
{
    public Guid Id { get; set; }
    public Guid SideId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public Guid SizeId { get; set; }
    public bool IsInCombo { get; set; } = false;
    public float? Price
    {
        get
        {

            if (Side != null && Size != null)
            {
                return Side.Price + Size.Price;
            }
            return null;
        }
    }
    public Guid? OrderComboId { get; set; }
    public Side? Side { get; set; }
    public Order? Order { get; set; }
    public Size? Size { get; set; }
}