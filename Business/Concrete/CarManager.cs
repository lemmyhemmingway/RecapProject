using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public void Add(Car car)
    {
        if (car.Name.Length > 2 && car.Price > 0)
            _carDal.Add(car);
        else
            Console.WriteLine(
                "Validation Failed: Car length must be longer than 2 characters and Price must be bigger than 0");
    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }

    public List<Car> GetByColorId(int id)
    {
        return _carDal.GetAll(c => c.ColorId == id);
    }

    public List<Car> GetByBrandId(int id)
    {
        return _carDal.GetAll(c => c.BrandId == id);
    }

    public List<CarDetailDto> CarDetails()
    {
        return _carDal.GetCarDetails();
    }
}