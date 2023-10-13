namespace KrustyKrab.Models;
public class Burger
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }

    public Order Order { get; set; }
    public List<BurgerTopping> Toppings { get; set; }
}