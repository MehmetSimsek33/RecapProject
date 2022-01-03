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
    public class CardManager : ICardService
    {
        private ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public IResult Add(Card card)
        {
            _cardDal.add(card);
            return new SuccessResult(Messages.CardAdded);
        }

        public IResult Delete(Card card)
        {
            _cardDal.delete(card);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(), Messages.CardGetAll);
        }

        public IDataResult<Card> GetByCardId(int cardId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(x => x.Id == cardId));
        }

        public IDataResult<List<Card>> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(x => x.CustomerId == customerId));
        }

        public IResult Update(Card card)
        {
            _cardDal.update(card);
            return new SuccessResult(Messages.CardUpdated);
        }
    }
}