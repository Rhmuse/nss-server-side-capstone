namespace KrustyKrab.Models;

public class BurgerTopping
{
    public Guid Id { get; set; }
    public Guid BurgerId { get; set; }
    public Guid ToppingId { get; set; }
    public bool Extra { get; set; } = false;
    public Topping? Topping { get; set; }
}