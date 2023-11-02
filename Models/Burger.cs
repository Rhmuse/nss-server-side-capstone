using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;
public class Burger
{
    public Guid Id { get; set; }
    public Guid? OrderId { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public bool IsInCombo { get; set; } = false;
    public Guid? OrderComboId { get; set; }
    public bool IsDeleted { get; set; } = false;
    [NotMapped]
    public float? Price
    {
        get
        {
            if (BurgerToppings?.Count > 0 && BurgerToppings[0].Topping != null)
            {
                float total = 0F;
                BurgerToppings.ForEach(t =>
                {
                    if (t.Extra)
                    {
                        total += t.Topping.Price * 2;
                    }
                    else
                    {
                        total += t.Topping.Price;
                    }
                });
                return total;
            }
            return null;
        }
    }
    public List<BurgerTopping>? BurgerToppings { get; set; }
}