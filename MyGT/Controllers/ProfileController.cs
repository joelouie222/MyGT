using MyGT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGT.Controllers
{
    public class ProfileController : Controller
    {
        
        public IActionResult UserProfile(int id = 0)
        {
            Profile connerFarley = new Profile();
            connerFarley.Id = id;
            connerFarley.FName = "Conner";
            connerFarley.LName = "Farley";
            connerFarley.PhoneNumber = "+1-555-978-3021";
            connerFarley.Age = 36;
            connerFarley.Address = "270 Prospect Court, Winter Haven, FL 33880";
            connerFarley.EmailAddress = "connfarley@yahoo.com";

            return View(connerFarley);
        }


        public IActionResult Register() => View();

        public IActionResult Login() => View();

        public IActionResult EditProfile(Profile user) => View(user);
    }
}
