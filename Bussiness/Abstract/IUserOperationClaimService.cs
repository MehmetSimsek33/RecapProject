using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<List<UserOperationClaim>> GetAll();
        IDataResult<UserOperationClaim> GetById(int id);
        IResult add(UserOperationClaim userOperationClaim);
        IResult delete(UserOperationClaim userOperationClaim);
        IResult update(UserOperationClaim userOperationClaim);
        IDataResult<List<UserOperationClaim>> GetCarsByUserId(int userId);
        IDataResult<List<UserOperationClaim>> GetCarsByClaimId(int claimId);

        IDataResult<List<UserOperationDto>> GetDetailsByOperationClaimId(int claimdId);
        IDataResult<List<UserOperationDto>> GetDetailsByUserId(int userId);

        // IDataResult<List<UserOperationDto>> GetCarsWithDetailsByBrandIdAndColorId(int claimdId, int userId);
        IDataResult<UserOperationDto> GetDetailsById(int detailId);
        IDataResult<List<UserOperationDto>> GetAllDetails();
    }
}
