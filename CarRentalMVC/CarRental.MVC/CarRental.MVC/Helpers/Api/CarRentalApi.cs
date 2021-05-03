using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarRental.MVC.Helpers.Api
{
    public class CarRentalApi
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54490");
            return client;
        }



        //CarRentalApi _api = new CarRentalApi();

        //public IActionResult GetCarModels()
        //{
        //    List<CarModelVM> carModels = new List<CarModelVM>();
        //    HttpClient client = _api.Initial();

        //    HttpResponseMessage response = client.GetAsync("api/car").Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var results = response.Content.ReadAsStringAsync().Result;
        //        carModels = JsonConvert.DeserializeObject<List<CarModelVM>>(results);
        //    }

        //    return View(carModels);
        //}


        //public async Task<IActionResult> GetCarModels()
        //{
        //    List<CarModelVM> carModels = new List<CarModelVM>();
        //    HttpClient client = _api.Initial();

        //    HttpResponseMessage response = await client.GetAsync("api/car");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var results = response.Content.ReadAsStringAsync().Result;
        //        carModels = JsonConvert.DeserializeObject<List<CarModelVM>>(results);
        //    }

        //    return View(carModels);
        //}
    }
}
