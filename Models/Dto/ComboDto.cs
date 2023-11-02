namespace KrustyKrab.Models;

public class ComboDto
{
    public Guid Id { get; set; }
    public OrderDrinkDto OrderDrinkDto { get; set; }
    public OrderSideDto OrderSideDto { get; set; }
    public BurgerDto BurgerDto { get; set; }
    public int Quantity { get; set; }
}