using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract {
    public interface IUserService {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        void DeleteById(int userId);
        User GetById(int userId);
        List<User> GetAll();
    }
}
