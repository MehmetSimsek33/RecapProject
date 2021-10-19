using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { id = 1, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 300, Description = "spor araba " },
                new Car { id = 2, BrandId = 2, ColorId = 3, ModelYear = "2002", DailyPrice = 100, Description = "aile araba" },
                new Car { id = 3, BrandId = 1, ColorId = 1, ModelYear = "2021", DailyPrice = 150, Description = "iş araba " },
                new Car { id = 4, BrandId = 1, ColorId = 2, ModelYear = "1987", DailyPrice = 180, Description = "Dağ araba" },
                new Car { id = 5, BrandId = 3, ColorId = 4, ModelYear = "1938", DailyPrice = 80, Description = "Van" },
            };
        }
            public void add(Car car)
        {
            _cars.Add(car);
        }

        public void delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(p => p.id == car.id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetAllColor(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(p => p.id == id);
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.id == car.id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
