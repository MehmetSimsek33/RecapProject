using Entities.Abstract;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetailDtos();
        List<CarDetailDto> GetCarDetailsByColorId(int colorId);
        List<CarDetailDto> GetCarDetailsByBrandId(int brandId);
        CarDetailDto GetCarDetailDto(int carId);
        List<CarDetailDto> GetCarsWithDetailsByBrandIdAndColorId(int brandId, int colorId);
    }
}
