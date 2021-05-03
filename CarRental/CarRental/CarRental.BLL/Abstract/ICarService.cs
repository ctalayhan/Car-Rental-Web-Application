using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        void DeleteById(int carId);
        Car GetById(int carId);
        List<Car> GetAll();
        List<CarsBasicDto> GetCarBasics();
        CarDetailsDto GetCarDetails(int id);
        AddedCarFormDto GetAddedCarFormInfos();
        UpdateCarDto GetUpdateCarFormInfos(int id);
    }
}
