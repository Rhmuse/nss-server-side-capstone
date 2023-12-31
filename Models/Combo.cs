namespace KrustyKrab.Models;

public class Combo
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public float Discount { get; set; }
    public Guid BurgerId { get; set; }
    public Burger? Burger { get; set; }
    public bool IsDeleted { get; set; } = false;
}