using CarRental.Core.DataAccess.BaseClasses.EntityFramework;
using CarRental.DAL.Abstract;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.DAL.Concrete.EntityFramework {
    public class EFEmployeeDal : EFRepositoryBase<Employee, CarRentalDBContext>, IEmployeeDal {
        
    }
}
