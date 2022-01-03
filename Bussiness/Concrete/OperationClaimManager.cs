using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationDal _operationDal;

        public OperationClaimManager(IOperationDal operationDal)
        {
            _operationDal = operationDal;
        }

        public IResult add(OperationClaim operationClaim)
        {
            _operationDal.add(operationClaim);
            return new SuccessResult(Messages.OperationClaimAdded);
        }

        public IResult delete(OperationClaim operationClaim)
        {
            _operationDal.delete(operationClaim);
            return new SuccessResult(Messages.OperationClaimDeleted);
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationDal.GetAll(), Messages.OperationClaimListed);
        }

        public IDataResult<OperationClaim> GetById(int id)
        {
            return new SuccessDataResult<OperationClaim>(_operationDal.Get(x => x.Id == id), Messages.OperationClaimGet);
        }

        public IResult update(OperationClaim operationClaim)
        {
            _operationDal.update(operationClaim);
            return new SuccessResult(Messages.OperationClaimUpdate);
        }
    }
}
