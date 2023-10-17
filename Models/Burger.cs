using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;
public class Burger
{
    public Guid Id { get; set; }
    public Guid? OrderId { get; set; }
    public int Quantity { get; set; }
    public Guid? ComboItemId { get; set; }
    [NotMapped]
    public float Price { get; set; }
    [NotMapped]
    public List<BurgerTopping>? Toppings { get; set; }
}