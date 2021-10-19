using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void add(Car car)
        {
            if(car.Description.Length>=2 && car.DailyPrice>0)
            {
                _cardal.add(car);
            }
            else


            {
                Console.WriteLine("Araba ismi 2 haneden yuksek olmalıdır ve fiyatı 0dan buyuk olmalıdır");
            }
        }

        public void delete(Car car)
        {
            
            _cardal.delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car GetById(int id)
        {
            return _cardal.Get(x => x.id == id);
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _cardal.GetCarDetailDtos();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cardal.GetAll(x => x.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cardal.GetAll(x => x.ColorId == colorId);
        }

        public void update(Car car)
        {
            _cardal.update(car);
        }
    }
}
