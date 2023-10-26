namespace KrustyKrab.Models;

public class Drink
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public bool IsDeleted { get; set; } = false;
}