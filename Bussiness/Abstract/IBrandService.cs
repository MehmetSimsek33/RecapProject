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
        List<Brand> GetAll();
        Brand GetById(int id);
        void add(Brand brand);
        void delete(Brand brand);
        void update(Brand brand);
    }
}
