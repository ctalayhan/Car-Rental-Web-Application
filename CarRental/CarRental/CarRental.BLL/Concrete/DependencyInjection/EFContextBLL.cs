using CarRental.BLL.Abstract;
using CarRental.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {
        public static void AddScopedBLL(this IServiceCollection services)
        {
            services.AddScopedDAL();
            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<IBrandModelDetailService, BrandModelDetailManager>();
            services.AddScoped<ICarBrandService, CarBrandManager>();
            services.AddScoped<ICarHistoryService, CarHistoryManager>();
            services.AddScoped<ICarStatusService, CarStatusManager>();
            services.AddScoped<ICarStatusTypeService, CarStatusTypeManager>();
            services.AddScoped<IContractService, ContractManager>();
            services.AddScoped<IDiscountService, DiscountManager>();
            services.AddScoped<IDriverLicenseClassService, DriverLicenseClassManager>();
            services.AddScoped<IDriverService, DriverManager>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IFuelTypeService, FuelTypeManager>();
            services.AddScoped<IGearService, GearManager>();
            services.AddScoped<IInsuranceService, InsuranceManager>();
            services.AddScoped<IModelService, ModelManager>();
            services.AddScoped<IReservationDetailService, ReservationDetailManager>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationStatusService, ReservationStatusManager>();
            services.AddScoped<IUserService, UserManager>();

        }
    }
}
