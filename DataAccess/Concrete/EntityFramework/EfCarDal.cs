using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (var context = new CarContext())
        {
            var cars = from c in context.Cars
                join brand in context.Brands on c.BrandId equals brand.Id
                join color in context.Colors on c.ColorId equals color.Id
                select new CarDetailDto
                {
                    BrandName = brand.BrandName,
                    CarId = c.Id,
                    CarName = c.Name,
                    ColorName = color.ColorName
                };

            return cars.ToList();
        }
    }
}