using CarRental.MVC.Helpers.Api;
using CarRental.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarRental.MVC.Controllers
{
    public class HomeController : Controller
    {
        CarRentalApi _api = new CarRentalApi();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginVM user)
        {

            var x = user;
            HttpClient client = _api.Initial();
            List<UserLoginVM> users = new List<UserLoginVM>();
            HttpResponseMessage response = client.GetAsync("/api/User").Result;

            if (response.IsSuccessStatusCode) {
                var results = response.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<UserLoginVM>>(results);
                var dataValue = users.Where(x => x.Username == user.Username).Where(x => x.Password == user.Password).Where(x => x.Role == true).FirstOrDefault();

                if (dataValue != null) {
                    var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, user.Username)

                    };
                    var userIdentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Dashboard", "Home");

                }

            }

            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> LogOut() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Register() {
            return View();
        }
        public IActionResult Dashboard() {
            return View();
        }


    }
}
