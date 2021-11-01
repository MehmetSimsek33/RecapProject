using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarContext>, IUserDal
    {
    }
}
