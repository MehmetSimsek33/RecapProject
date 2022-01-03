using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICardService
    {
        IResult Add(Card card);
        IResult Update(Card card);
        IResult Delete(Card card);

        IDataResult<List<Card>> GetAll();
        IDataResult<Card> GetByCardId(int cardId);
        IDataResult<List<Card>> GetByCustomerId(int customerId);
    }
}