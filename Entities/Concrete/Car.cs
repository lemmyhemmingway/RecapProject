using Entities.Abstract;

namespace Entities.Concrete;

// Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)


public class Car: IEntity
{

    public int Id { get; set; }
    public int BrandId { get; set; }
    public int ColorId { get; set; }
    public DateOnly ModelYear { get; set; }
    public decimal DailyPrice { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"{Description}, {DailyPrice}, {ModelYear.Year}";
    }
}