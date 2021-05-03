using CarRental.DTO;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        void DeleteById(int employeeId);
        Employee GetById(int employeeId);
        List<Employee> GetAll();
        public EmployeeAddDto GetEmployeeAddInfo();
        public List<EmployeeBasicDto> GetEmployeeBasicInfo();
        public EmployeeDetailedDto GetEmployeeDetailedInfo(int id);
        public EmployeeUpdateDto GetEmployeeUpdateInfo(int id);
    }
}
