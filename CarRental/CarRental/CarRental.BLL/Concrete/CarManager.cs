using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.DTO.DTOs;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.BLL.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        ICarBrandDal _carBrandDal;
        ICarStatusTypeDal _carStatusTypeDal;
        IGearDal _gearDal;
        IFuelTypeDal _fuelTypeDal;
        IModelDal _modelDal;
        public CarManager(ICarDal carDal, ICarBrandDal carBrandDal, ICarStatusTypeDal carStatusTypeDal, IGearDal gearDal, IFuelTypeDal fuelTypeDal, IModelDal modelDal)
        {
            _carDal = carDal;
            _carBrandDal = carBrandDal;
            _carStatusTypeDal = carStatusTypeDal;
            _gearDal = gearDal;
            _fuelTypeDal = fuelTypeDal;
            _modelDal = modelDal;

        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void DeleteById(int carId)
        {
            _carDal.Delete(_carDal.Get(x => x.CarID == carId));
        }

        public AddedCarFormDto GetAddedCarFormInfos()
        {


            var gears = _gearDal.GetAll();
            var fuelTypes = _fuelTypeDal.GetAll();
            var modelList = _modelDal.GetAll();

            AddedCarFormDto formInfos = new AddedCarFormDto();
            List<GearsDto> gearDtos = new List<GearsDto>();
            List<FuelTypesDto> fuelTypeDtos = new List<FuelTypesDto>();
            List<ModelsDto> modelDtos = new List<ModelsDto>();

            foreach (var item in gears)
            {
                gearDtos.Add(new GearsDto()
                {
                    GearID = item.GearID,
                    GearType = item.GearType
                });
            }

            foreach (var item in fuelTypes)
            {
                fuelTypeDtos.Add(new FuelTypesDto()
                {
                    FuelTypeID = item.FuelTypeID,
                    FuelTypeName = item.FuelTypeName,
                    Description = item.Description
                });
            }

            foreach (var item in modelList)
            {
                modelDtos.Add(new ModelsDto()
                {
                    BrandRefID = item.BrandRefID,
                    ModelID = item.ModelID,
                    ModelName = item.ModelName
                });
            }

            formInfos.GearTypeList = gearDtos;
            formInfos.FuelTypeList = fuelTypeDtos;
            formInfos.ModelList = modelDtos;




            return formInfos;
        }

        public CarDetailsDto GetCarDetails(int id)
        {

            var car = _carDal.Get(x => x.CarID == id, x => x.CarStatus, x => x.BrandModelDetail, x=>x.CarHistories, x=>x.Gear, x=>x.FuelType);
            var carBrands = _carBrandDal.GetAll(null, x => x.Models);
            var statusTypes = _carStatusTypeDal.GetAll(null);


            CarDetailsDto carDetailsDto = new CarDetailsDto();

            carDetailsDto.CarID = car.CarID;
            carDetailsDto.ModelYear = car.BrandModelDetail.ModelYear;
            carDetailsDto.ChassisNo = car.ChassisNo;
            carDetailsDto.GearType = car.Gear.GearType;
            carDetailsDto.PlateNo = car.PlateNo;
            carDetailsDto.FuelType = car.FuelType.FuelTypeName;
            carDetailsDto.Image = car.BrandModelDetail.Image;
            carDetailsDto.DailyFee = car.DailyFee;


            foreach (var carHistory in car.CarHistories.Where(x=> x.CarID == car.CarID))
            {
                CarHistoriesDto carHistoriesDto = new CarHistoriesDto();
                carHistoriesDto.CarID = carHistory.CarID;
                carHistoriesDto.ID = carHistory.ID;
                carHistoriesDto.InspectionDate = carHistory.InspectionDate;
                carHistoriesDto.VisaDate = carHistory.VisaDate;
                carDetailsDto.CarHistories.Add(carHistoriesDto);

            }

            foreach (var status in car.CarStatus)
            {

                foreach (var statusType in statusTypes)
                {
                    if (statusType.StateID == status.StatusID)
                    {
                        carDetailsDto.StatusName = statusType.StatusDescription;
                    }
                }
            }

            foreach (var brand in carBrands)
            {
                foreach (var model in brand.Models)
                {
                    if (model.BrandRefID == car.BrandModelDetail.BrandRefID)
                    {
                        carDetailsDto.BrandName = brand.BrandName;
                        carDetailsDto.ModelName = model.ModelName;
                    }
                }
            }



            return carDetailsDto;
        }


        //public CarUpdateDto GetCarUpdateInfo(int id)
        //{
        //    var car = _carDal.Get(x => x.CarID == id, x => x.CarStatus, x => x.BrandModelDetail, x => x.CarHistories, x => x.Gear, x => x.FuelType);
        //    var carBrands = _carBrandDal.GetAll(null, x => x.Models);
        //    var statusTypes = _carStatusTypeDal.GetAll(null);

        //    CarUpdateDto carUpdateDto = new CarUpdateDto();
        //    carUpdateDto.CarID = car.CarID;
        //    carUpdateDto.ModelYear = car.BrandModelDetail.ModelYear;
        //    carUpdateDto.ChassisNo = car.ChassisNo;
        //    carUpdateDto.GearType = car.Gear.GearType;
        //    carUpdateDto.PlateNo = car.PlateNo;
        //    carUpdateDto.FuelType = car.FuelType.FuelTypeName;
        //    carUpdateDto.Image = car.BrandModelDetail.Image;
        //    carUpdateDto.DailyFee = car.DailyFee;

        //    var gears = _gearDal.GetAll();
        //    var fuelTypes = _fuelTypeDal.GetAll();
        //    var modelList = _modelDal.GetAll();

        //    List<GearsDto> gearDtos = new List<GearsDto>();
        //    List<FuelTypesDto> fuelTypeDtos = new List<FuelTypesDto>();
        //    List<ModelsDto> modelDtos = new List<ModelsDto>();

        //    foreach (var item in gears)
        //    {
        //        gearDtos.Add(new GearsDto()
        //        {
        //            GearID = item.GearID,
        //            GearType = item.GearType
        //        });
        //    }

        //    foreach (var item in fuelTypes)
        //    {
        //        fuelTypeDtos.Add(new FuelTypesDto()
        //        {
        //            FuelTypeID = item.FuelTypeID,
        //            FuelTypeName = item.FuelTypeName,
        //            Description = item.Description
        //        });
        //    }

        //    foreach (var item in modelList)
        //    {
        //        modelDtos.Add(new ModelsDto()
        //        {
        //            BrandRefID = item.BrandRefID,
        //            ModelID = item.ModelID,
        //            ModelName = item.ModelName
        //        });
        //    }

        //    UpdateCarDto updateCarDto = new UpdateCarDto()
        //    {
        //        CarID = result.CarID,
        //        PlateNo = result.PlateNo,
        //        ChassisNo = result.ChassisNo,
        //        GearID = result.GearID,
        //        BrandModelDetailID = result.BrandModelDetailID,
        //        FuelTypeID = result.FuelTypeID,
        //        DailyFee = result.DailyFee,
        //    };

        //    updateCarDto.GearTypeList = gearDtos;
        //    updateCarDto.FuelTypeList = fuelTypeDtos;
        //    updateCarDto.ModelList = modelDtos;

        //    return updateCarDto;
        //}


        public UpdateCarDto GetUpdateCarFormInfos(int id)
        {

            var result = _carDal.Get(x => x.CarID == id);
            var gears = _gearDal.GetAll();
            var fuelTypes = _fuelTypeDal.GetAll();
            var modelList = _modelDal.GetAll();

            List<GearsDto> gearDtos = new List<GearsDto>();
            List<FuelTypesDto> fuelTypeDtos = new List<FuelTypesDto>();
            List<ModelsDto> modelDtos = new List<ModelsDto>();

            foreach (var item in gears)
            {
                gearDtos.Add(new GearsDto()
                {
                    GearID = item.GearID,
                    GearType = item.GearType
                });
            }

            foreach (var item in fuelTypes)
            {
                fuelTypeDtos.Add(new FuelTypesDto()
                {
                    FuelTypeID = item.FuelTypeID,
                    FuelTypeName = item.FuelTypeName,
                    Description = item.Description
                });
            }

            foreach (var item in modelList)
            {
                modelDtos.Add(new ModelsDto()
                {
                    BrandRefID = item.BrandRefID,
                    ModelID = item.ModelID,
                    ModelName = item.ModelName
                });
            }

            UpdateCarDto updateCarDto = new UpdateCarDto()
            {
                CarID = result.CarID,
                PlateNo = result.PlateNo,
                ChassisNo = result.ChassisNo,
                GearID = result.GearID,
                BrandModelDetailID = result.BrandModelDetailID,
                FuelTypeID = result.FuelTypeID,
                DailyFee = result.DailyFee,
            };

            updateCarDto.GearTypeList = gearDtos;
            updateCarDto.FuelTypeList = fuelTypeDtos;
            updateCarDto.ModelList = modelDtos;

            return updateCarDto;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(x => x.CarID == carId);
        }

        public List<CarsBasicDto> GetCarBasics()
        {
            var basics = _carDal.GetAll(null, x => x.CarStatus, x => x.BrandModelDetail);
            var carBrands = _carBrandDal.GetAll(null, x => x.Models);
            var statusTypes = _carStatusTypeDal.GetAll(null);


            List<CarsBasicDto> carsBasicDtos = new List<CarsBasicDto>();
            foreach (var item in basics)
            {
                CarsBasicDto carsBasicDto = new CarsBasicDto();

                carsBasicDto.CarID = item.CarID;
                carsBasicDto.ModelYear = item.BrandModelDetail.ModelYear;

                foreach (var status in item.CarStatus)
                {

                    foreach (var statusType in statusTypes)
                    {
                        if (statusType.StateID == status.StatusID)
                        {
                            carsBasicDto.StatusName = statusType.StatusDescription;
                        }
                    }
                }

                foreach (var brand in carBrands)
                {
                    foreach (var model in brand.Models)
                    {
                        if (model.BrandRefID == item.BrandModelDetail.BrandRefID)
                        {
                            carsBasicDto.BrandName = brand.BrandName;
                            carsBasicDto.ModelName = model.ModelName;
                        }
                    }
                }

                carsBasicDtos.Add(carsBasicDto);
            }

            return carsBasicDtos;

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
