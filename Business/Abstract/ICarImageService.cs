using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICarImageService
{
    IResult Add(CarImage carImage);
    IDataResult<List<CarImage>> GetByCarId(int id);
}