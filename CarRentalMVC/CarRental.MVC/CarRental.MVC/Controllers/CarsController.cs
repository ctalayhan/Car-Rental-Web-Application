using CarRental.MVC.Helpers.Api;
using CarRental.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.MVC.Controllers
{
    public class CarsController : Controller
    {
      
        CarRentalApi _api = new CarRentalApi();
        
        public IActionResult GetAllCars()
        {
            HttpClient client = _api.Initial();
            List<CarBasicsVM> carBasics = new List<CarBasicsVM>();

            HttpResponseMessage response = client.GetAsync("/api/Car/GetCarBasics").Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                carBasics = JsonConvert.DeserializeObject<List<CarBasicsVM>>(results);
            }

            return View(carBasics);
        }

        [HttpGet]
        public IActionResult AddCar()

        {

            HttpClient client = _api.Initial();
            AddCarVM car = new AddCarVM();

            HttpResponseMessage response = client.GetAsync("/api/Car/GetAddedCarFormInfos").Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                car = JsonConvert.DeserializeObject<AddCarVM>(results);
            }

            return View(car);

        }

        public IActionResult DeleteCar(int id)
        {
            HttpClient client = _api.Initial();
            
            HttpResponseMessage response = client.DeleteAsync("/api/Car/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllCars");
            }
            return View();
        }
        //[HttpGet]
        //public IActionResult DeleteCar(int id)
        //{
        //    HttpClient client = _api.Initial();
        //    HttpResponseMessage response = client.DeleteAsync("/api/Car/DeleteById" + id).Result;

        //    if (response.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("GetAllCars");
        //    }
        //    return View();
        //}

        [HttpPost]
        public IActionResult AddCar(AddCarVM addCarVm)
        {
            var request = Request.Form.Files.FirstOrDefault();
            if (request != null)
            {
                MemoryStream ms = new MemoryStream();
                request.CopyTo(ms);
                addCarVm.Image = ms.ToArray();
                ms.Close();
                ms.Dispose();
            }

            HttpClient client = _api.Initial();
            var serializedCar = new StringContent(JsonConvert.SerializeObject(addCarVm), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync("/api/Car", serializedCar).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllCars");
            }
            return View(addCarVm);
        }

        [HttpGet]
        public IActionResult CarDetails(int id)
        {
            HttpClient client = _api.Initial();
            CarDetailsVM carDetails = new CarDetailsVM();

            HttpResponseMessage response = client.GetAsync("/api/Car/GetCarDetails/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                carDetails = JsonConvert.DeserializeObject<CarDetailsVM>(results);
            }
            return View(carDetails);
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            HttpClient client = _api.Initial();
            CarDetailsVM carDetails = new CarDetailsVM();

            HttpResponseMessage response = client.GetAsync("/api/Car/GetCarDetails/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                carDetails = JsonConvert.DeserializeObject<CarDetailsVM>(results);
            }
            return View(carDetails);
        }


        //[HttpGet]
        //public IActionResult CarDetails(int id)
        //{
        //    HttpClient client = _api.Initial();
        //    CarUpdateVM carDetails = new CarUpdateVM();

        //    HttpResponseMessage response = client.GetAsync("/api/Car/GetUpdateCarFormInfos/" + id).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var results = response.Content.ReadAsStringAsync().Result;
        //        carDetails = JsonConvert.DeserializeObject<CarUpdateVM>(results);
        //    }
        //    return View(carDetails);
        //}

        [HttpPost]
        public IActionResult CarDetails(CarUpdateVM carUpdateVM, int id)
        {
            HttpClient client = _api.Initial();
            CarUpdateVM car = new CarUpdateVM();

            carUpdateVM.CarID = id;
            var serializedCar = new StringContent(JsonConvert.SerializeObject(carUpdateVM), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync("/api/Car/", serializedCar).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("CarDetails");
            }
            return View(carUpdateVM);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            HttpClient client = _api.Initial();
            CarVM deletedCar = new CarVM();

            HttpResponseMessage response = client.GetAsync("/api/Car/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                deletedCar = JsonConvert.DeserializeObject<CarVM>(results);
            }
            return View("GetAllCars");
        }


        //[HttpPost]
        //public async Task<bool> UpdateCar(CarVM carVM, int id)
        //{
        //    HttpClient client = _api.Initial();
        //    var stringContent = new StringContent(JsonConvert.SerializeObject(carVM), Encoding.UTF8, "application/json");
        //    var response = await client.PutAsync("Car", stringContent);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
