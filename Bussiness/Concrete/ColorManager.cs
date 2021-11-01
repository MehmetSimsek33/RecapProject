using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult add(Color color)
        {
            _colorDal.add(color);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult delete(Color color)
        {
            _colorDal.delete(color);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ProductListed);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(x => x.id == id),Messages.ProductListed);
        }

        public IResult update(Color color)
        {
            _colorDal.update(color);
            return new SuccessResult(Messages.ProductUpdate);
            
        }
    }
}
