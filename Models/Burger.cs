using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;
public class Burger
{
    public Guid Id { get; set; }
    public Guid? OrderId { get; set; }
    public int Quantity { get; set; }
    [NotMapped]
    public float? Price
    {
        get
        {
            if (Toppings?.Count > 0)
            {
                float total = 0F;
                Toppings.ForEach(t =>
                {
                    total += t.Topping.Price;
                });
                return total;
            }
            return null;
        }
    }
    [NotMapped]
    public List<BurgerTopping>? Toppings { get; set; }
}