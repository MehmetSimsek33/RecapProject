using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
   public class EfCustomerDal: EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetail(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 UserId = u.Id,
                                 CustomerId = c.id,
                                 CompanyName = c.CompanyName,
                                 Email = u.Email,
                                 FirstName = u.Email,
                                 LastName = u.LastName,
                                 Status = u.Status,
                                 FullName = $"{u.FirstName} {u.LastName}",
                                 CustomerFindexPoint = c.CustomerFindexPoint
                             };
                return result.ToList();
            }
        }
    }
}