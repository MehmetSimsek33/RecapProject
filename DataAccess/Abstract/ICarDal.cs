using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetAllByBrand(int brandId);
        List<Car> GetAllColor(int colorId);
        Car GetById(int id);
        void add(Car car);
        void delete(Car car);
        void update(Car car);
    }
}
