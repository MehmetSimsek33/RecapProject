using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewrok;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarDetailDtoTest();
           // CarTest();


            //Car cars = new Car();
            //cars.id = 1;
            //cars.BrandId = 1;
            //cars.ColorId = 1;
            //cars.ModelYear = "2020";
            //cars.DailyPrice = 300;
            //cars.Description = "A";
            //carManager.add(cars);
        }
        static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.add(new Car() { BrandId = 4, ColorId = 1, DailyPrice = 250, ModelYear = "32", Description = "mercedes" });
            var car = carManager.GetById(2).Data;
            car.Description = "bmv";
            carManager.update(car);
        }

        private static void CarDetailDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.Description + " " + car.BrandName + " " + car.ColorName
                    + " " + car.DailyPrice + " " + car.ModelYear);
            }
        }
    }
}