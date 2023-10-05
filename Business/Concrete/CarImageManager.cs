using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarImageManager: ICarImageService
{
    private readonly ICarImageDal _carImageDal;

    public CarImageManager(ICarImageDal carImageDal)
    {
        _carImageDal = carImageDal;
    }

    public IResult Add(CarImage carImage)
    {
        ChangeImageNameToGuid(carImage);
        _carImageDal.Add(carImage);
        return new SuccessResult();
    }

    public IDataResult<List<CarImage>> GetByCarId(int id)
    {
        return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
    }

    private void ChangeImageNameToGuid(CarImage carImage)
    {
        carImage.ImagePath = new Guid().ToString();
    }
}