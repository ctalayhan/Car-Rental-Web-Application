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
using System.Text;
using System.Threading.Tasks;

namespace CarRental.MVC.Controllers
{
    public class DepartmentsController : Controller
    {
       
        CarRentalApi _api = new CarRentalApi();
 
        public IActionResult GetAllEmployees()
        {
            HttpClient client = _api.Initial();
            List<EmployeeBasicInfoVM> employees = new List<EmployeeBasicInfoVM>();

            HttpResponseMessage response = client.GetAsync("/api/Employee/GetAllEmployeeBasicInfo").Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<EmployeeBasicInfoVM>>(results);
            }

            return View(employees);
        }


        public IActionResult AddEmployee()
        {
            HttpClient client = _api.Initial();
            EmployeeAddVM employee = new EmployeeAddVM();

            HttpResponseMessage response = client.GetAsync("/api/Employee/AddEmployee/").Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<EmployeeAddVM>(results);
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeAddVM employee)
        {
            var request = Request.Form.Files.FirstOrDefault();
            if (request != null)
            {
                MemoryStream ms = new MemoryStream();
                request.CopyTo(ms);
                employee.Image = ms.ToArray();
                ms.Close();
                ms.Dispose();
            }
            HttpClient client = _api.Initial();

            var serializedEmployee = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync("/api/Employee/",serializedEmployee).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllEmployees");
            }
            return View(employee);
        }

        public IActionResult EmployeeDetails(int id)
        {
            HttpClient client = _api.Initial();
            EmployeeDetailedVM employee = new EmployeeDetailedVM();

            HttpResponseMessage response = client.GetAsync("/api/Employee/GetEmployeeDetailedInfo/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<EmployeeDetailedVM>(results);
            }
            return View(employee);
        }

        public IActionResult UpdateEmployee(int id)
        {

            HttpClient client = _api.Initial();
            EmployeeUpdateVM employee = new EmployeeUpdateVM();

            HttpResponseMessage response = client.GetAsync("/api/Employee/GetEmployeeUpdateInfo/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var results = response.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<EmployeeUpdateVM>(results);
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult UpdateEmployee(int id, EmployeeVM ed)
        {
            var request = Request.Form.Files.FirstOrDefault();
            if (request != null)
            {
                MemoryStream ms = new MemoryStream();
                request.CopyTo(ms);
                ed.Image = ms.ToArray();
                ms.Close();
                ms.Dispose();
            }

            HttpClient client = _api.Initial();
            ed.EmployeeID = id;

            var serializedEmployee = new StringContent(JsonConvert.SerializeObject(ed), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync("/api/Employee/", serializedEmployee).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllEmployees");
            }
            return View(ed);
        }
    }
}
