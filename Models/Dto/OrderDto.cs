namespace KrustyKrab.Models;

public class OrderDto
{
    public Order Order { get; set; }
    public List<OrderDrinkDto> OrderDrinkDtos { get; set; }
    public List<OrderSideDto> OrderSideDtos { get; set; }
    public List<BurgerDto> BurgerDtos { get; set; }
    public List<ComboDto> ComboDtos { get; set; }

}