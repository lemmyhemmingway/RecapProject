using Core.Utilities.Results;
using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);

    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetByColorId(int id);
    IDataResult<List<Car>> GetByBrandId(int id);
    IDataResult<List<CarDetailDto>> CarDetails();
}