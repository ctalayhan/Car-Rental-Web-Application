using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete {
    public class UserManager :IUserService {
        IUserDal _userDal;
        public UserManager(IUserDal userDal) {
            _userDal = userDal;

        }

        public void Add(User user) {
            _userDal.Add(user);
        }

        public void Delete(User user) {
            _userDal.Delete(user);
        }

        public void DeleteById(int userId) {
            _userDal.Delete(_userDal.Get(x => x.UserID == userId));
        }

        public List<User> GetAll() {
            return _userDal.GetAll();
        }

        public User GetById(int userId) {
            return _userDal.Get(x => x.UserID == userId);
        }

        public void Update(User user) {
            _userDal.Update(user);
        }
    }
}
