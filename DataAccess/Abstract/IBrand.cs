using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IBrand
    {
        Brand GetById(int id);
        void add(Brand brand);
        void delete(Brand brand);
        void update(Brand brand);
    }
}
