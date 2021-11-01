
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IColorService
    {

        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int id);
        IResult add(Color color);
        IResult delete(Color color);
        IResult update(Color color);
    }
}
