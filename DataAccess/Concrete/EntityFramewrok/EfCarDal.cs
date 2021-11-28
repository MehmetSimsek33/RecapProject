using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.id
                             join cl in context.Colors on c.ColorId equals cl.id
                             select new CarDetailDto
                             {
                                 id = c.id,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description


                             };
                return result.ToList();

            }
        }
        
         public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.id
                             join cl in context.Colors on c.ColorId equals cl.id
                             where c.ColorId == colorId
                             select new CarDetailDto
                             {
                                 id = c.id,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description


                             };
                return result.ToList();

            }
        }
        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.id
                             join cl in context.Colors on c.ColorId equals cl.id
                             where c.BrandId == brandId
                             select new CarDetailDto
                             {
                                 id = c.id,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description


                             };
                return result.ToList();

            }
        }
    }
}

