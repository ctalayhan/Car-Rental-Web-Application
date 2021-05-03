using CarRental.Core.DataAccess.IBaseRepositories;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Abstract {
    public interface IUserDal : IRepository<User> {
    }
}
