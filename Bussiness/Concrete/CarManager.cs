using Bussines.BusimessAspect.Autofac;
using Bussiness.Abstract;

using Bussiness.Constants;
using Bussiness.ValidationRules;
using Core.Aspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.CrosCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;


        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IDataResult<Car> add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarDescriptionExist(car.Description));
            _cardal.add(car);
            return new SuccessDataResult<Car>(car, Messages.ProductAdded);

            //if (result != null)
            //{
            //    return result;
            //}
            //else
            //{ _cardal.add(car);
           // return new SuccessDataResult<Car>(car, Messages.ProductAdded);

            //}
        }

        public IResult Delete(int id)
        {
            var result = _cardal.Get(c => c.id == id);
            _cardal.delete(result);
            return new SuccessResult(Messages.ProductDeleted);
        }


        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car> (_cardal.Get(x => x.id == id),Messages.ProductListed);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(),Messages.ProductListed);
        }
        public IDataResult<List<CarDetailDto>>  GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetailDtos(),Messages.ProductListed);

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(x => x.BrandId == brandId),Messages.ProductListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(x => x.ColorId == colorId), Messages.ProductListed);
        }
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult update(Car car)
        {
            _cardal.update(car);
          return new SuccessResult(Messages.ProductUpdate);
        }

        private IResult CheckIfCarDescriptionExist(string description)
        {
            var result = _cardal.GetAll(p => p.Description == description).Any();
            if (result)
            {
                return new ErrorResult("Bu isimde kayıt olmaz");
            }
            return new SuccessResult();
        }

        public IResult AddTransactionTest(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetailsByBrandId(brandId), Messages.ProductListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarDetailsByColorId(colorId), Messages.ProductListed);
        }

        public IDataResult<CarDetailDto> GetCarDetailDto(int carId)
        {
            return new SuccessDataResult<CarDetailDto>(_cardal.GetCarDetailDto(carId), "Araba Bilgileri");
        }

        public IDataResult<List<CarDetailDto>> GetCarsWithDetailsByBrandIdAndColorId(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cardal.GetCarsWithDetailsByBrandIdAndColorId(brandId,colorId), Messages.ProductListed);
        }
    }
    
}
