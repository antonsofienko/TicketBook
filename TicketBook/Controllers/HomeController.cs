using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketBook.Models;
using TicketBook.BusinessLayer.Services;
using TicketBook.DataAccessLayer;
using TicketBook.Data;

namespace TicketBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly AirportService _airportService;
        IUnitOfWork _unitOfWork;
        public HomeController(ApplicationDbContext dbCotext)
        {

            _unitOfWork = new ApplicationUnitOfWork(dbCotext);
            _airportService = new AirportService(_unitOfWork);
        }

        public ActionResult Index()
        {
            var cities = _airportService.Cities;
            return View(cities);
        }

        public ActionResult Search(SearchInputViewModel model)
        {
            var errorString = string.Empty;
            if (model.DepartureCityId == Guid.Empty)
            {
                errorString += "Select departure city. ";
            }
            if (model.ArrivalCityId == Guid.Empty)
            {
                errorString += "Select arrival city. ";
            }
            if (model.DepartureDate == null)
            {
                errorString += "Select date ";
            }

            if (errorString != string.Empty)
            {
                ViewBag.Error = errorString;
                return View();
            }
            else
            {
                var fligths = _airportService.FindFlights(model.DepartureCityId, model.ArrivalCityId, model.DepartureDate.Value);
                return View("SearchResult",fligths);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
