using Bussiness.Abstract;
using Bussiness.Constants;
using Bussiness.ValidationRules;
using Core.Aspects.Autofac;
using Core.Aspects.Autofac.Caching;
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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult add(Brand brand)
        {

            _brandDal.add(brand);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult delete(Brand brand)
        {
            _brandDal.delete(brand);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>> (_brandDal.GetAll(),Messages.ProductListed);
        }
        [CacheAspect]
        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult< Brand >(_brandDal.Get(x => x.id == id),Messages.ProductListed);

        }

        public IResult update(Brand brand)
        {
            _brandDal.update(brand);
            return new SuccessResult(Messages.ProductUpdate);
        }

        
    }
}
