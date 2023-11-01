namespace KrustyKrab.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid OrderTypeId { get; set; }
    public Guid? CustomerId { get; set; }
    public Guid EmployeeId { get; set; }
    public DateTime OrderTime { get; set; } = DateTime.Now;
    public OrderType? OrderType { get; set; }
    public UserProfile? Customer { get; set; }
    public UserProfile? Employee { get; set; }
    public List<Burger>? Burgers { get; set; }
    public List<OrderDrink>? Drinks { get; set; }
    public List<OrderSide>? Sides { get; set; }
    public List<ComboItem>? ComboItems { get; set; }
}