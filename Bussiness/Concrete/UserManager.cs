using Bussines.Abstract;
using Bussiness.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{

        public class UserManager : IUserService
        {
            private IUserDal _userDal;

            public UserManager(IUserDal userDal)
            {
                _userDal = userDal;
            }

            
            public IResult Add(User user)
            {
                _userDal.add(user);
                return new SuccessResult(Messages.UserAdded);
            }

            public IResult Delete(User user)
            {
                _userDal.delete(user);
                return new SuccessResult(Messages.UserDeleted);
            }

            public IDataResult<User> Get(int id)
            {
                return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id), Messages.UserGet);
            }

            public IDataResult<List<User>> GetAll()
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserGetAll);
            }

            public IDataResult<User> GetByMail(string email)
            {
                return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
            }

            public List<OperationClaim> GetClaims(User user)
            {
                return _userDal.GetClaims(user);
            }

            public IResult Update(User user)
            {
                _userDal.update(user);
                return new SuccessResult(Messages.UserUpdated);
            }
        }
    }