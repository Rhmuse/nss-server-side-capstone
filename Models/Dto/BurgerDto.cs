namespace KrustyKrab.Models;
public class BurgerDto
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    public bool IsModified { get; set; }
    public float Price { get; set; }
    public List<BurgerToppingDto> BurgerToppingDtos { get; set; }
}