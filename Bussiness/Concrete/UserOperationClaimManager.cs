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
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IResult add(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.add(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimAdded);
        }

        public IResult delete(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.delete(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimDeleted);
        }
        public IResult update(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.update(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimUpdated);
        }
        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll(), Messages.UserOperationClaimListed);
        }
        public IDataResult<UserOperationClaim> GetById(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimDal.Get(x => x.Id == id), Messages.UserOperationClaimGet);
        }

        public IDataResult<List<UserOperationDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<UserOperationDto>>(_userOperationClaimDal.getAllDetails(), Messages.ProductListed);
        }


        public IDataResult<UserOperationDto> GetDetailsById(int detailId)
        {
            return new SuccessDataResult<UserOperationDto>(_userOperationClaimDal.GetDetailsById(detailId),Messages.UserOperationClaimListed);
        }

        public IDataResult<List<UserOperationDto>> GetDetailsByOperationClaimId(int claimdId)
        {
            return new SuccessDataResult<List<UserOperationDto>>(_userOperationClaimDal.GetDetailsByOperationClaimId(claimdId), Messages.ProductListed);
        }
        

        public IDataResult<List<UserOperationDto>> GetDetailsByUserId(int userId)
        {
            return new SuccessDataResult<List<UserOperationDto>>(_userOperationClaimDal.GetDetailsByUserId(userId), Messages.ProductListed);

        }

        public IDataResult<List<UserOperationClaim>> GetCarsByUserId(int userId)
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll(x => x.UserId == userId), Messages.ProductListed);
        }

        public IDataResult<List<UserOperationClaim>> GetCarsByClaimId(int claimId)
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll(x => x.OperationClaimId == claimId), Messages.ProductListed);

        }
    }
}
