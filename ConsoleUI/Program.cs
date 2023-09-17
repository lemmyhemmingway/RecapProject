using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

void CarTest()
{
    var cm = new CarManager(new EfCarDal());
    foreach (var c in cm.GetAll())
    {
        Console.WriteLine(c);
    }
}


var cm = new CarManager(new EfCarDal());

var cars = cm.CarDetails();
foreach (var c in cars)
{
    Console.WriteLine($"{c.CarId} | {c.BrandName} | {c.CarName} | {c.ColorName}");
}