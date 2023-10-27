namespace KrustyKrab.Models;

public class NewBurgerDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public List<BurgerToppingDto> Toppings { get; set; }
}