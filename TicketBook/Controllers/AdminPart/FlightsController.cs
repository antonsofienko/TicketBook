using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketBook.Data;
using TicketBook.DataAccessLayer.DomainModel;
using Microsoft.AspNetCore.Authorization;

namespace TicketBook.Controllers.AdminPart
{

    [Route("admin/[controller]/[action]")]
    [Authorize(Roles = "admin")]
    public class FlightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Flights
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Flights.Include(f => f.Airplane).Include(f => f.ArrivalCity).Include(f => f.DepartureCity);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .Include(f => f.Airplane)
                .Include(f => f.ArrivalCity)
                .Include(f => f.DepartureCity)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // GET: Flights/Create
        public IActionResult Create()
        {
            ViewData["AirplaneId"] = new SelectList(_context.Airplanes, "Id", "Id");
            ViewData["ArrivalCityId"] = new SelectList(_context.Cities, "Id", "Id");
            ViewData["DepartureCityId"] = new SelectList(_context.Cities, "Id", "Id");
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AirplaneId,ArrivalCityId,DepartureCityId,ArivalTime,DepartureTime,AvaliableTicket")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AirplaneId"] = new SelectList(_context.Airplanes, "Id", "Id", flight.AirplaneId);
            ViewData["ArrivalCityId"] = new SelectList(_context.Cities, "Id", "Id", flight.ArrivalCityId);
            ViewData["DepartureCityId"] = new SelectList(_context.Cities, "Id", "Id", flight.DepartureCityId);
            return View(flight);
        }

        // GET: Flights/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights.SingleOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }
            ViewData["AirplaneId"] = new SelectList(_context.Airplanes, "Id", "Id", flight.AirplaneId);
            ViewData["ArrivalCityId"] = new SelectList(_context.Cities, "Id", "Id", flight.ArrivalCityId);
            ViewData["DepartureCityId"] = new SelectList(_context.Cities, "Id", "Id", flight.DepartureCityId);
            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AirplaneId,ArrivalCityId,DepartureCityId,ArivalTime,DepartureTime,AvaliableTicket")] Flight flight)
        {
            if (id != flight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(flight.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AirplaneId"] = new SelectList(_context.Airplanes, "Id", "Id", flight.AirplaneId);
            ViewData["ArrivalCityId"] = new SelectList(_context.Cities, "Id", "Id", flight.ArrivalCityId);
            ViewData["DepartureCityId"] = new SelectList(_context.Cities, "Id", "Id", flight.DepartureCityId);
            return View(flight);
        }

        // GET: Flights/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .Include(f => f.Airplane)
                .Include(f => f.ArrivalCity)
                .Include(f => f.DepartureCity)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flight = await _context.Flights.SingleOrDefaultAsync(m => m.Id == id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.Id == id);
        }
    }
}
