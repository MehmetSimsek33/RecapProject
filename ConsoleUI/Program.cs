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
            CarManager carManager = new CarManager(new EfCarDal());
            
            Car cars = new Car();
            cars.id = 1;
            cars.BrandId = 1;
            cars.ColorId = 1;
            cars.ModelYear = "2020";
            cars.DailyPrice = 300;
            cars.Description = "A";
            carManager.add(cars);
           
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
        
            
            
        }
    }
}
