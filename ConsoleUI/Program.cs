using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

void CarTest()
{
    var cm = new CarManager(new EfCarDal());
    var d = cm.GetAll();
    var data = d.Data;
    foreach (var c in data)
    {
        Console.WriteLine(c);
    }
}


var cm = new CarManager(new EfCarDal());

var cars = cm.CarDetails();
foreach (var c in cars.Data)
{
    Console.WriteLine($"{c.CarId} | {c.BrandName} | {c.CarName} | {c.ColorName}");
}