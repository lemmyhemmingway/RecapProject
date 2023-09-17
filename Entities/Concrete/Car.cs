using Core.Entities;

namespace Entities.Concrete;

public class Car : IEntity
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int ColorId { get; set; }
    public int ModelYear { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public override string ToString()
    {
        return $"{Id} | {BrandId} | {ColorId} | {ModelYear} | {Price} | {Name} | {Description}";
    }
}