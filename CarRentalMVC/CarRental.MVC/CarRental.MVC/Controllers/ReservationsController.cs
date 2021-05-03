using CarRental.MVC.Helpers.Api;
using CarRental.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace CarRental.MVC.Controllers
{
    public class ReservationsController : Controller
    {
        CarRentalApi _api = new CarRentalApi();
        public IActionResult GetAllReservations()
        {
            HttpClient client = _api.Initial();
            List<ReservationModelVM> reservationModels = new List<ReservationModelVM>();

            HttpResponseMessage response = client.GetAsync("/api/Reservation").Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                reservationModels = JsonConvert.DeserializeObject<List<ReservationModelVM>>(results);
            }
            return View(reservationModels);
        }

        public IActionResult ReservationDetails(int Id)
        {
            HttpClient client = _api.Initial();
            List<ReservationDetailsVM> reservationDetails = new List<ReservationDetailsVM>();

            HttpResponseMessage response = client.GetAsync("/api/ReservationDetail/" + Id).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                reservationDetails = JsonConvert.DeserializeObject<List<ReservationDetailsVM>>(results);


            }
            return View(reservationDetails);
        }
        
        public IActionResult ReservationDetailsUpdate(string id)
        {
            var a = id.Split('-');
            int revId = Convert.ToInt32(a[0]);
            int carId = Convert.ToInt32(a[1]);


            HttpClient client = _api.Initial();
            List<ReservationDetailsVM> reservationDetails = new List<ReservationDetailsVM>();
            
            HttpResponseMessage response = client.GetAsync("/api/ReservationDetail/" + revId).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                reservationDetails = JsonConvert.DeserializeObject<List<ReservationDetailsVM>>(results);


            }
            ReservationDetailsVM reservationDetailsVM = new ReservationDetailsVM();
            reservationDetailsVM = reservationDetails.FirstOrDefault(x => x.CarID == carId);
            return View(reservationDetailsVM);
        }

        [HttpPost]
        public IActionResult ReservationDetailsUpdate(ReservationDetailsVM reservationDetailsVM)
        {
            HttpClient client = _api.Initial();
            ReservationDetailsVM reservationDetails = new ReservationDetailsVM();

            var stringContent = new StringContent(JsonConvert.SerializeObject(reservationDetailsVM), Encoding.UTF8, "application/json");

            var response = client.PutAsync("/api/ReservationDetail/" , stringContent).Result;

            if (response.IsSuccessStatusCode)
            {
                return View();
            }
            else
            {
                return RedirectToAction("GetAllReservations");
            }
        }


    }
}
