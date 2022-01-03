using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
   public class EfOperationClaimdal : EfEntityRepositoryBase<OperationClaim, CarContext>, IOperationDal
    {
    }
}
