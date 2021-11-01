
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
   public interface IBrandService
    {
        IDataResult<List<Brand>>  GetAll();
        IDataResult<Brand> GetById(int id);
        IResult add(Brand brand);
        IResult delete(Brand brand);
        IResult update(Brand brand);
    }
}
