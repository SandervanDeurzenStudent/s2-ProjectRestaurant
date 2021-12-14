using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Models
{
    public class ReservationViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}