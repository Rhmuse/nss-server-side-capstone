namespace KrustyKrab.Models;

public class ComboDto
{
    public Guid Id { get; set; }
    public List<ComboItemDto> ComboItemDtos { get; set; }
}