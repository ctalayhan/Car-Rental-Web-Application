using AutoMapper;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DTO.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<CarStatus, CarStatusesDto>();
            CreateMap<CarStatusesDto, CarStatus>();

            CreateMap<CarStatusType, CarStatusTypeDto>();
            CreateMap<CarStatusTypeDto, CarStatusType>();

            CreateMap<FuelType, FuelTypesDto>();
            CreateMap<FuelTypesDto, FuelType>();

            CreateMap<Gear, GearsDto>();
            CreateMap<GearsDto, Gear>();

            CreateMap<Employee, EmployeesDto>();
            CreateMap<EmployeesDto, Employee>();

            CreateMap<Car, CarsDto>();
            CreateMap<CarsDto, Car>();

            CreateMap<List<Car>, List<CarsDto>>();
            CreateMap<List<CarsDto>, List<Car>>();

            CreateMap<BrandModelDetail, BrandModelDetailsDto>();
            CreateMap<BrandModelDetailsDto, BrandModelDetail>();

            CreateMap<CarBrand, CarBrandsDto>();
            CreateMap<CarBrandsDto, CarBrand>();

            CreateMap<CarHistory, CarHistoriesDto>();
            CreateMap<CarHistoriesDto, CarHistory>();

            CreateMap<Contract, ContractsDto>();
            CreateMap<ContractsDto, Contract>();

            CreateMap<Discount, DiscountsDto>();
            CreateMap<DiscountsDto, Discount>();

            CreateMap<Driver, DriversDto>();
            CreateMap<DriversDto, Driver>();

            CreateMap<DriverLicenseClass, DriverLicensesDto>();
            CreateMap<DriverLicensesDto, DriverLicenseClass>();

            CreateMap<Insurance, InsurancesDto>();
            CreateMap<InsurancesDto, Insurance>();

            CreateMap<Model, ModelsDto>();
            CreateMap<ModelsDto, Model>();

            CreateMap<ReservationStatus, ReservationStatusesDto>();
            CreateMap<ReservationStatusesDto, ReservationStatus>();

            CreateMap<ReservationDetail, ReservationDetailsDto>();
            CreateMap<ReservationDetailsDto, ReservationDetail>();

            CreateMap<Reservation, ReservationsDto>();
            CreateMap<ReservationsDto, Reservation>();

            CreateMap<User, UsersDto>();
            CreateMap<UsersDto, User>();

        }


    }
}
