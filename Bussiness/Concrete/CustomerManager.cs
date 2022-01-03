using Bussiness.Abstract;
using Bussiness.Constants;
using Bussiness.ValidationRules;
using Core.Aspects.Autofac;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _cusomerDal;

        public CustomerManager(ICustomerDal cusomerDal)
        {
            _cusomerDal = cusomerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult add(Customer customer)
        {
            _cusomerDal.add(customer);
            return new SuccessResult("Başarı ile Müşteri eklendi tebrikler");
        }

        public IResult delete(Customer customer)
        {
            _cusomerDal.delete(customer);
            return new SuccessResult("Başarı ile Müşteri silindi tebrikler");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_cusomerDal.GetAll(), "Basarili sekılde musteri bilgisi getirildi");

        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_cusomerDal.Get(x => x.id == id),"Basarili sekılde musteri bilgisi getirildi");
        }

        public IResult update(Customer customer)
        {
            _cusomerDal.update(customer);
            return new SuccessResult("Başarı ile Müşteri güncellendi tebrikler");
        }
        public IDataResult<Customer> GetByUserId(int userId)
        {
            return new SuccessDataResult<Customer>(_cusomerDal.Get(c => c.UserId == userId), Messages.CustomerGetByUserId);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_cusomerDal.GetCustomerDetail(), Messages.GetCustomerDetail);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetailById(int id)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_cusomerDal.GetCustomerDetail(x => x.CustomerId == id));
        }
    }
}
