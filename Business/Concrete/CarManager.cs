using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

    public IDataResult<List<Car>> GetAll()
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
    }

    public IResult Add(Car car)
    {
        if (car.Name.Length < 2 || car.Price < 0)
            return new ErrorResult(Messages.CarInvalid);
        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
    }

    public IDataResult<List<Car>> GetByColorId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
    }

    public IDataResult<List<Car>> GetByBrandId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
    }

    public IDataResult<List<CarDetailDto>> CarDetails()
    {
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
    }
}