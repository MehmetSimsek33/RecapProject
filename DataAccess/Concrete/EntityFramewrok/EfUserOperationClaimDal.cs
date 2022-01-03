using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewrok
{
    //EfUserOperationClaimDal
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, CarContext>, IUserOperationClaimDal
    {

        public UserOperationDto GetDetailsById(int userOperationClaimId)
        {
            using (CarContext context = new CarContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join user in context.Users on userOperationClaim.UserId equals user.Id
                             join operationClaims in context.OperationClaims on userOperationClaim.OperationClaimId equals operationClaims.Id
                             where userOperationClaim.Id == userOperationClaimId
                             select new UserOperationDto
                             {
                                 id = userOperationClaim.Id,
                                 OperationName=operationClaims.Name,
                                 UserFirstName=user.FirstName,
                                 UserLastName=user.LastName,
                                 UserFullName=user.FirstName+""+user.LastName,
                                 email=user.Email
                                
                                

                             };
                return result.SingleOrDefault();

            }
        }
        public List<UserOperationDto> getAllDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join user in context.Users on userOperationClaim.UserId equals user.Id
                             join operationClaims in context.OperationClaims on userOperationClaim.OperationClaimId equals operationClaims.Id
                             select new UserOperationDto
                             {
                              id=userOperationClaim.Id,
                                 OperationName = operationClaims.Name,
                                 UserFirstName = user.FirstName,
                                 UserLastName = user.LastName,
                                 UserFullName = user.FirstName + "" + user.LastName,
                                 email = user.Email



                             };
                return result.ToList();

            }
        }
      

        public List<UserOperationDto> GetDetailsByUserId(int userId)
        {
            using (CarContext context = new CarContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join user in context.Users on userOperationClaim.UserId equals user.Id
                             join operationClaims in context.OperationClaims on userOperationClaim.OperationClaimId equals operationClaims.Id
                             where userOperationClaim.UserId == userId
                             select new UserOperationDto
                             {
                                 id = userOperationClaim.Id,
                                 OperationName = operationClaims.Name,
                                 UserFirstName = user.FirstName,
                                 UserLastName = user.LastName,
                                 UserFullName = user.FirstName + "" + user.LastName,
                                 email = user.Email



                             };
                return result.ToList();

            }
        }
        public List<UserOperationDto> GetDetailsByOperationClaimId(int operationClaimI)
        {
            using (CarContext context = new CarContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join user in context.Users on userOperationClaim.UserId equals user.Id
                             join operationClaims in context.OperationClaims on userOperationClaim.OperationClaimId equals operationClaims.Id
                             where userOperationClaim.OperationClaimId == operationClaimI
                             select new UserOperationDto
                             {
                                 id = userOperationClaim.Id,
                                 OperationName = operationClaims.Name,
                                 UserFirstName = user.FirstName,
                                 UserLastName = user.LastName,
                                 UserFullName = user.FirstName + "" + user.LastName,
                                 email = user.Email



                             };
                return result.ToList();

            }
        }
    
    }
}

