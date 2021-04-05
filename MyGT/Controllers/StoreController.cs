using Microsoft.AspNetCore.Mvc;
using MyGT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGT.Controllers
{
    public class StoreController : Controller
    {
        // Methods

        // Create
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(StoreProfile store)
        {
            return View();
        }

        // Read

        // Update

        // Delete


    }
}
