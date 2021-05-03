using CarRental.DAL.Abstract;
using CarRental.DAL.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Concrete.DependencyInjection
{
    public static class EFContextDAL
    {
        public static void AddScopedDAL(this IServiceCollection services)
        {
            services.AddScoped<ICarDal, EFCarDal>();
            services.AddScoped<IBrandModelDetailDal, EFBrandModelDetailDal>();
            services.AddScoped<ICarBrandDal, EFCarBrandDal>();
            services.AddScoped<ICarHistoryDal, EFCarHistoryDal>();
            services.AddScoped<ICarStatusDal, EFCarStatusDal>();
            services.AddScoped<ICarStatusTypeDal, EFCarStatusTypeDal>();
            services.AddScoped<IContractDal, EFContractDal>();
            services.AddScoped<IDiscountDal, EFDiscountDal>();
            services.AddScoped<IDriverLicenseClassDal, EFDriverLicenseClassDal>();
            services.AddScoped<IDriverDal, EFDriverDal>();
            services.AddScoped<IEmployeeDal, EFEmployeeDal>();
            services.AddScoped<IFuelTypeDal, EFFuelTypeDal>();
            services.AddScoped<IGearDal, EFGearDal>();
            services.AddScoped<IInsuranceDal, EFInsuranceDal>();
            services.AddScoped<IModelDal, EFModelDal>();
            services.AddScoped<IReservationDetailDal, EFReservationDetailDal>();
            services.AddScoped<IReservationDal, EFReservationDal>();
            services.AddScoped<IReservationStatusDal, EFReservationStatusDal>();
            services.AddScoped<IUserDal, EFUserDal>();
        }
    }
}
