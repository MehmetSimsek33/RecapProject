
using Core.Utilities.Results;
using Entities.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId);
        
        IDataResult<List<CarDetailDto>>  GetCarDetailDtos();
        IDataResult<Car> GetById(int id);
        IResult add(Car car);
        IResult delete(Car car);
        IResult update(Car car);

        IResult AddTransactionTest(Car car);
    }
}
