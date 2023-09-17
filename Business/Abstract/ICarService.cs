using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);

    List<Car> GetByColorId(int id);
    List<Car> GetByBrandId(int id);
    List<CarDetailDto> CarDetails();
}