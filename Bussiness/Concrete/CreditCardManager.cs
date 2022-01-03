using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;
    
      

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
      
        }
         //[Authentication]
        public IResult Save(CreditCard card)
        {
          
            //var result = BusinessRules.Run(IsCardExist(card.CardNumber));
            //if (result != null)
            //{
            //    return result;
            //}
          //  else
            
                _creditCardDal.add(card);

            return new SuccessResult(Messages.CreditCardAdded);
        }

       // [Authentication]
        public IDataResult<List<CreditCard>> GetByCustomerCrediCartss(int customerId)
        {

            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(x => x.CustomerId == customerId));

        }

        private IResult IsCardExist(string cardNumber)
        {
            var result = _creditCardDal.Get(c => c.CardNumber == cardNumber);
            if (result != null)
            {
                return new ErrorResult(Messages.CardAlreadyExist);
            }
            return new SuccessResult();
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
                
                return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(), Messages.CardGetAll);
            
        }
    }
}