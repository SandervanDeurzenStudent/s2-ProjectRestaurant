using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces.Reservations;
using Microsoft.AspNetCore.Mvc;
using Presentation.Converter;
using Presentation.Models.IndexModels;

namespace Presentation.Models
{
    public class ReservationViewController : Controller
    {
        IReservationContainer _reservationContainer;
        ReservationViewConverter _reservationViewConverter;
        public ReservationViewController(IReservationContainer reservationContainer, ReservationViewConverter reservationViewConverter)
        {
            _reservationContainer = reservationContainer;
            _reservationViewConverter = reservationViewConverter;
        }
        public IActionResult Index()
        {
            IndexReservationViewModel indexRestaurantViewModel = new IndexReservationViewModel
            {
                reservationList = _reservationViewConverter.Convert_To_ReservationViewModel(_reservationContainer.GetList())
            };

            return View(indexRestaurantViewModel);
            return View();
        }
        public IActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Time,Restaurant_id,user_id")] ReservationViewModel reservationModel, int? RestaurantId)
        {
            if (ModelState.IsValid)
            {
                _reservationContainer.create(_reservationViewConverter.Convert_To_ReservationModel(reservationModel), Convert.ToInt32(RestaurantId), 1);
                return RedirectToAction(nameof(Index));
            }
            return View(reservationModel);
        }

    }
}