using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
   
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAll();
        IResult Update(Rental rental);
        IResult Delete(Rental rental);

        IDataResult<List<RentalDetailDto>> GetRentalDetailDto();
    }
}
