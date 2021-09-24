using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
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
            _cardal.add(car);
        }

        public void delete(Car car)
        {
            _cardal.delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cardal.GetAllByBrand(brandId);
        }

        public List<Car> GetAllColor(int colorId)
        {
            return _cardal.GetAllColor(colorId);
        }

        public Car GetById(int id)
        {
            return _cardal.GetById(id);
        }

        public void update(Car car)
        {
            _cardal.update(car);
        }
    }
}
