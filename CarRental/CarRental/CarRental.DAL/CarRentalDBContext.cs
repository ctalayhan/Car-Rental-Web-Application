using CarRental.DAL.Mapping;
using CarRental.DAL.Seeding;
using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL {
    public class CarRentalDBContext : DbContext {
        #region DbSets
        public DbSet<Car> Cars { get; set; }
        public DbSet<BrandModelDetail> BrandModelDetails { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarHistory> CarHistories { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<CarStatusType> CarStatusesTypes { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverLicenseClass> DriverLicenseClasses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDetail> ReservationDetails { get; set; }
        public DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=.;Database=CarRentalDB;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            #region MappingConfiguration
            modelBuilder.ApplyConfiguration(new CarMapping());
            modelBuilder.ApplyConfiguration(new CarBrandMapping());
            modelBuilder.ApplyConfiguration(new BrandModelDetailMapping());
            modelBuilder.ApplyConfiguration(new CarHistoryMapping());
            modelBuilder.ApplyConfiguration(new CarStatusMapping());
            modelBuilder.ApplyConfiguration(new CarStatusTypeMapping());
            modelBuilder.ApplyConfiguration(new ContractMapping());
            modelBuilder.ApplyConfiguration(new DiscountMapping());
            modelBuilder.ApplyConfiguration(new DriverLicenseMapping());
            modelBuilder.ApplyConfiguration(new DriverMapping());
            modelBuilder.ApplyConfiguration(new EmployeeMapping());
            modelBuilder.ApplyConfiguration(new FuelTypeMapping());
            modelBuilder.ApplyConfiguration(new GearMapping());
            modelBuilder.ApplyConfiguration(new InsuranceMapping());
            modelBuilder.ApplyConfiguration(new ModelMapping());
            modelBuilder.ApplyConfiguration(new ReservationDetailMapping());
            modelBuilder.ApplyConfiguration(new ReservationMapping());
            modelBuilder.ApplyConfiguration(new ReservationStatusMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
            #endregion   
            modelBuilder.ModelSeedData();
            modelBuilder.ContractSeedData();
            modelBuilder.CarBrandSeedData();
            modelBuilder.BrandModelDetailSeedData();            
            modelBuilder.CarHistorySeedData();
            modelBuilder.CarSeedData();
            modelBuilder.CarStatusSeedData();
            modelBuilder.CarStatusTypeSeedData();
            modelBuilder.DiscountSeedData();
            modelBuilder.DriverSeedData();
            modelBuilder.DriverLicenseSeedData();
            modelBuilder.EmployeeSeedData();
            modelBuilder.FuelTypeSeedData();
            modelBuilder.GearSeedData();
            modelBuilder.InsuranceSeedData();           
            modelBuilder.ReservationDetailSeedData();
            modelBuilder.ReservationSeedData();
            modelBuilder.ReservationStatusSeedData();
            modelBuilder.UserSeedData();

        }
    }
}
