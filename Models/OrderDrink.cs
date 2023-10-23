using System.ComponentModel.DataAnnotations.Schema;

namespace KrustyKrab.Models;

public class OrderDrink
{
    public Guid Id { get; set; }
    public Guid DrinkId { get; set; }
    public Guid OrderId { get; set; }
    public int Quantity { get; set; }
    public Guid SizeId { get; set; }
    [NotMapped]
    public Drink? Drink { get; set; }
    [NotMapped]
    public Order? Order { get; set; }
}