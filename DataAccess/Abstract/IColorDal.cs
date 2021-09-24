using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        Color GetById(int id);
        void add(Color color);
        void delete(Color color);
        void update(Color color);
    }
}
