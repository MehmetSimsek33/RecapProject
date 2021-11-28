using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentaldal)
        {
            _rentalDal = rentaldal;
        }

        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate == null)
            {
                _rentalDal.add(rental);
                return new SuccessResult("Başarı ile arabayi kiraladınız tebrikler");
            }
            else
            {
                return new ErrorResult("Malesef araba su an baskasi tarafindan kiralanmıstır ");
            }
               

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.delete(rental);
            return new SuccessResult("Rental deleted!");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == id));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDto()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetailDtos(), Messages.ProductListed);
        }

        public IResult Update(Rental rental)
        {

            _rentalDal.update(rental);
            return new SuccessResult("Rental updated!");
        }
    }
}
