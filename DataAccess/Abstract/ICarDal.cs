using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICarDal
{
    List<Car> GetAll();
    Car? Find(Car car);
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);

}