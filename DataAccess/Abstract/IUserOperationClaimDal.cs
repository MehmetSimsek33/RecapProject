using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserOperationClaimDal : IEntityRepository<UserOperationClaim>
    {
    List<UserOperationDto> GetDetailsByOperationClaimId(int claimdId);
        List<UserOperationDto> GetDetailsByUserId(int userId);

        // IDataResult<List<UserOperationDto>> GetCarsWithDetailsByBrandIdAndColorId(int claimdId, int userId);
        UserOperationDto GetDetailsById(int detailId);
       List<UserOperationDto> getAllDetails();
    }
}
