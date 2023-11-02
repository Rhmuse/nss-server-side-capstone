namespace KrustyKrab.Models;

public class OrderDrink
{
    public Guid Id { get; set; }
    public Guid DrinkId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public Guid SizeId { get; set; }
    public bool IsInCombo { get; set; } = false;
    public Guid? OrderComboId { get; set; }
    public Drink? Drink { get; set; }
    public Order? Order { get; set; }
}