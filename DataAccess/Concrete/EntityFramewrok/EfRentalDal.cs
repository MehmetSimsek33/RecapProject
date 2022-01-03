using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
   public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (CarContext context = new CarContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.id
                             join brand in context.Brands on car.BrandId equals brand.id
                             join customer in context.Customers on rental.CustomerId equals customer.id
                             join user in context.Users on customer.UserId equals user.Id

                             select new RentalDetailDto
                             {
                                 id = rental.Id,
                                 CarBrandName = brand.BrandName,
                                 CustomerFirstNameLastName = user.FirstName +" "+ user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 CarDesciription=car.Description



                             };
                return result.ToList();

            }
        }
    }
}
