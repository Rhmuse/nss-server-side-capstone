using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;

public class BurgerTopping
{
    public Guid Id { get; set; }
    public Guid BurgerId { get; set; }
    public Guid ToppingId { get; set; }
    [NotMapped]
    public Topping? Topping { get; set; }
}