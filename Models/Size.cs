namespace KrustyKrab.Models;

public class Size
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ShortHand { get; set; }
    public float Price { get; set; }
    public bool IsDeleted { get; set; } = false;
}