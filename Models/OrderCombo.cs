namespace KrustyKrab.Models;

public class OrderCombo
{
    public Guid Id { get; set; }
    public Guid ComboId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public float? Price
    {
        get
        {
            if (OrderDrink != null && OrderSide != null && Burger != null)
            {
                float? total = 0F;
                total += OrderDrink.Price;
                total += OrderSide.Price;
                total += Burger.Price;
                return total;
            }
            return null;
        }
    }
    public OrderDrink? OrderDrink { get; set; }
    public OrderSide? OrderSide { get; set; }
    public Burger? Burger { get; set; }
}