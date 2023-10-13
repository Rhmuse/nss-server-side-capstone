namespace KrustyKrab.Models;

public class BurgerTopping
{
    public Guid Id { get; set; }
    public Guid BurgerId { get; set; }
    public Guid ToppingId { get; set; }

    public Burger Burger { get; set; }
    public Topping Topping { get; set; }
}