using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;
    private readonly ICarImageService _carImageService;

    public CarManager(ICarDal carDal, ICarImageService carImageService)
    {
        _carDal = carDal;
        _carImageService = carImageService;
    }

    public IDataResult<List<Car>> GetAll()
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
    }

    [ValidationAspect(typeof(CarValidator))]
    public IResult Add(Car car)
    {
        _carDal.Add(car);
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

    private IResult CheckCarImageLimit(int id)
    {
        var result = _carImageService.GetByCarId(id);
        if (result.Data.Count > 5)
        {
            return new ErrorResult(); 
        }

        return new SuccessResult();

    }
}