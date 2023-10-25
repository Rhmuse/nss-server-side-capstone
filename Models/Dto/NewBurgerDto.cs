namespace KrustyKrab.Models;

public class NewBurgerDto
{
    public string Name { get; set; }
    public List<BurgerToppingDto> Toppings { get; set; }
}