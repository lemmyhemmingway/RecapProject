// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

ICarDal carDal = new InMemoryCarDal();
CarManager cm = new CarManager(carDal);
var cars = cm.GetAll();
foreach (var car in cars)
{
    Console.WriteLine(car);
}
