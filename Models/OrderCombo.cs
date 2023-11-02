namespace KrustyKrab.Models;

public class OrderCombo
{
    public Guid Id { get; set; }
    public Guid ComboId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public OrderDrink? OrderDrink { get; set; }
    public OrderSide? OrderSide { get; set; }
    public Burger? Burger { get; set; }
}