using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.DTO;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public void DeleteById(int employeeId)
        {
            _employeeDal.Delete(_employeeDal.Get(x => x.EmployeeID == employeeId));
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int employeeId)
        {
            return _employeeDal.Get(x => x.EmployeeID == employeeId);
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }


        public List<EmployeeBasicDto> GetEmployeeBasicInfo()
        {
            var result = _employeeDal.GetAll(null, x => x.Employees);
            List<EmployeeBasicDto> employeeDetailedDtos = new List<EmployeeBasicDto>();

            foreach (var item in result)
            {
                employeeDetailedDtos.Add(new EmployeeBasicDto()
                {
                    EmployeeID = item.EmployeeID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Phone = item.Phone,
                    DirectorName = item.ReportsToID == null ? null : item.ReportsTo.FirstName + " " + item.ReportsTo.LastName,
                });
            }
            return employeeDetailedDtos;
        }

        public EmployeeDetailedDto GetEmployeeDetailedInfo(int id)
        {
            var result = _employeeDal.Get(x => x.EmployeeID == id, x => x.ReportsTo);
            EmployeeDetailedDto employeeDetailedDto = new EmployeeDetailedDto()
            {
                EmployeeID = result.EmployeeID,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Gender = result.Gender,
                BloodType = result.BloodType,
                Email = result.Email,
                Education = result.Education,
                BirthDate = result.BirthDate,
                Phone = result.Phone,
                Address = result.Address,
                DirectorName = result.ReportsToID == null ? null : result.ReportsTo.FirstName + " " + result.ReportsTo.LastName,
                Image = result.Image,
                Summary = result.Summary,
            };
            return employeeDetailedDto;
        }
        public EmployeeAddDto GetEmployeeAddInfo()
        {
            var result = _employeeDal.GetAll();
            List<DirectorsDto> directors = new List<DirectorsDto>();
            foreach (var employee in result)
            {
                directors.Add(new DirectorsDto() { DirectorId = employee.EmployeeID, DirectorName = $"{employee.FirstName} {employee.LastName}" });
            }
            EmployeeAddDto employeeAdd = new EmployeeAddDto()
            {
                Directors = directors,
            };
            return employeeAdd;
        }

        public EmployeeUpdateDto GetEmployeeUpdateInfo(int id)
        {
            var result = _employeeDal.Get(x => x.EmployeeID == id);
            var employees = _employeeDal.GetAll();
            //var b = employees.Where(x=>x.EmployeeID == id); // 94. ve 95. satır tek seferde çekilerek code refactoring yapılabilir. Daha sonra bak
            List<DirectorsDto> directors = new List<DirectorsDto>();
            foreach (var item in employees)
            {
                directors.Add(new DirectorsDto() { DirectorId = item.EmployeeID, DirectorName = item.FirstName + " " + item.LastName });
            }

            EmployeeUpdateDto employeeUpdateDto = new EmployeeUpdateDto()
            {
                EmployeeID = result.EmployeeID,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Gender = result.Gender,
                BloodType = result.BloodType,
                Email = result.Email,
                Education = result.Education,
                BirthDate = result.BirthDate,
                Phone = result.Phone,
                Address = result.Address,
                ReportsToID = result.ReportsToID,
                Image = result.Image,
                Summary = result.Summary,
                Directors = directors,
            };
            return employeeUpdateDto;
        }
    }
}
