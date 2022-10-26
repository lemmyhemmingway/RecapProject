using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal: ICarDal
{
    private List<Car> _cars;

    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car{Id = 1, BrandId = 1, ColorId = 1, Description = "It is a car", ModelYear = DateOnly.FromDateTime(new DateTime()), DailyPrice = 1},
            new Car{ Id = 2, BrandId = 4, ColorId = 7, Description = "It is another car", ModelYear = DateOnly.FromDateTime(new DateTime(2012, 2, 2)), DailyPrice = 444}
        };
    }
    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car? Find(Car car)
    {
        return _cars.SingleOrDefault(c => c.Id == car.Id);
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        var c = Find(car);
        if (c != null)
        {
            c.Description = car.Description;
            c.BrandId = car.BrandId;
            c.ColorId = car.ColorId;
            c.DailyPrice = car.DailyPrice;
            c.ModelYear = car.ModelYear;
        }
    }

    public void Delete(Car car)
    {
        var c = Find(car);
        if (c != null) _cars.Remove(c);
    }
}