namespace KrustyKrab.Models;

public class Order
{
    private readonly float Tax = 0.08F;
    public Guid Id { get; set; }
    public Guid OrderTypeId { get; set; }
    public Guid? CustomerId { get; set; }
    public Guid EmployeeId { get; set; }
    public DateTime OrderTime { get; set; } = DateTime.Now;
    public float? Total
    {
        get
        {
            if (SubTotal != null) return SubTotal + (SubTotal * Tax);
            return null;
        }
    }
    public float? SubTotal
    {
        get
        {
            if (Burgers?.Count > 0 || OrderDrinks?.Count > 0 || OrderSides?.Count > 0 || OrderCombos?.Count > 0)
            {
                float? subTotal = 0F;
                if (Burgers?.Count > 0) Burgers.ForEach(b =>
                    {
                        if (!b.IsInCombo) subTotal += b.Price * b.Quantity;
                    }
                );

                if (OrderDrinks?.Count > 0) OrderDrinks.ForEach(d =>
                    {
                        if (!d.IsInCombo) subTotal += d.Price * d.Quantity;
                    }
                );

                if (OrderSides?.Count > 0) OrderSides.ForEach(s =>
                    {
                        if (!s.IsInCombo) subTotal += s.Price * s.Quantity;
                    }
                );

                if (OrderCombos?.Count > 0) OrderCombos.ForEach(oc => subTotal += oc.Price * oc.Quantity);

                return subTotal;
            }
            return null;
        }
    }
    public OrderType? OrderType { get; set; }
    public UserProfile? Customer { get; set; }
    public UserProfile? Employee { get; set; }
    public List<Burger>? Burgers { get; set; }
    public List<OrderDrink>? OrderDrinks { get; set; }
    public List<OrderSide>? OrderSides { get; set; }
    public List<OrderCombo>? OrderCombos { get; set; }
}