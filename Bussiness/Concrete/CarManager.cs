using Bussines.BusimessAspect.Autofac;
using Bussiness.Abstract;

using Bussiness.Constants;
using Bussiness.ValidationRules;
using Core.Aspects.Autofac;
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
        public IResult add(Car car)
        {

            IResult result = BusinessRules.Run(CheckIfCarDescriptionExist(car.Description));
            if (result != null)
            {
                return result;
            }
            else
            {
                _cardal.add(car);
                return new SuccessResult(Messages.ProductAdded); ;
            }

       
           
        }

        public IResult delete(Car car)
        {

            return new SuccessResult(Messages.ProductDeleted);
        }


        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car> (_cardal.Get(x => x.id == id),Messages.ProductListed);
        }

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
    }
    
}
