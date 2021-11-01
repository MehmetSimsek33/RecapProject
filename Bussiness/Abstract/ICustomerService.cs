using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
   public interface ICustomerService
    {

        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);
        IResult add(Customer customer);
        IResult delete(Customer customer);
        IResult update(Customer customer);
    }
}
