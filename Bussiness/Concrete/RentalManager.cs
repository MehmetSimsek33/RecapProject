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

            var results = _rentalDal.GetAll(re => re.CarId == rental.CarId);
            foreach (var result in results)
            {
                if (result.ReturnDate == null ||
                    (rental.RentDate >= result.RentDate && rental.RentDate <= result.ReturnDate) ||
                    (rental.ReturnDate >= result.RentDate && rental.RentDate <= result.ReturnDate)
                    || (rental.RentDate < DateTime.Now || rental.RentDate > rental.ReturnDate) 
                    )
                {
                    return new ErrorResult("Araç şu anda kiralanamaz");
                }
            }

            _rentalDal.add(rental);
            return new SuccessResult("Araç Kiralandi");


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
