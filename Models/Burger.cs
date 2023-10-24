using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;
public class Burger
{
    public Guid Id { get; set; }
    public Guid? OrderId { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    [NotMapped]
    public float? Price
    {
        get
        {
            if (BurgerToppings?.Count > 0)
            {
                float total = 0F;
                BurgerToppings.ForEach(t =>
                {
                    total += t.Topping.Price;
                });
                return total;
            }
            return null;
        }
    }
    public List<BurgerTopping>? BurgerToppings { get; set; }
}