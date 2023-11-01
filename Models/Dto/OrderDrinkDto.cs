namespace KrustyKrab.Models;

public class OrderDrinkDto
{
    public Guid DrinkId { get; set; }
    public int Quantity { get; set; }
    public Guid SizeId { get; set; }
}