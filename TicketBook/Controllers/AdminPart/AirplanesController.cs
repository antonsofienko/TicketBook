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
    public class AirplanesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirplanesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Airplanes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Airplanes.ToListAsync());
        }

        // GET: Airplanes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplanes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (airplane == null)
            {
                return NotFound();
            }

            return View(airplane);
        }

        // GET: Airplanes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Airplanes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SeatingPlace")] Airplane airplane)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airplane);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airplane);
        }

        // GET: Airplanes/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplanes.SingleOrDefaultAsync(m => m.Id == id);
            if (airplane == null)
            {
                return NotFound();
            }
            return View(airplane);
        }

        // POST: Airplanes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,SeatingPlace")] Airplane airplane)
        {
            if (id != airplane.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airplane);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirplaneExists(airplane.Id))
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
            return View(airplane);
        }

        // GET: Airplanes/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplane = await _context.Airplanes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (airplane == null)
            {
                return NotFound();
            }

            return View(airplane);
        }

        // POST: Airplanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var airplane = await _context.Airplanes.SingleOrDefaultAsync(m => m.Id == id);
            _context.Airplanes.Remove(airplane);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirplaneExists(Guid id)
        {
            return _context.Airplanes.Any(e => e.Id == id);
        }
    }
}
