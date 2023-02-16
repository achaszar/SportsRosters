using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsRosters.Data;
using SportsRosters.Models;

namespace SportsRosters.Controllers
{
    public class BaseballRostersController : Controller
    {
        private readonly SportsRostersContext _context;

        public BaseballRostersController(SportsRostersContext context)
        {
            _context = context;
        }

        // GET: BaseballRosters
        public async Task<IActionResult> Index()
        {
              return View(await _context.BaseballRoster.ToListAsync());
        }

        // GET: BaseballRosters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BaseballRoster == null)
            {
                return NotFound();
            }

            var baseballRoster = await _context.BaseballRoster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baseballRoster == null)
            {
                return NotFound();
            }

            return View(baseballRoster);
        }

        // GET: BaseballRosters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BaseballRosters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Number,Position,Bats,Throws")] BaseballRoster baseballRoster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(baseballRoster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(baseballRoster);
        }

        // GET: BaseballRosters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BaseballRoster == null)
            {
                return NotFound();
            }

            var baseballRoster = await _context.BaseballRoster.FindAsync(id);
            if (baseballRoster == null)
            {
                return NotFound();
            }
            return View(baseballRoster);
        }

        // POST: BaseballRosters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Number,Position,Bats,Throws")] BaseballRoster baseballRoster)
        {
            if (id != baseballRoster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baseballRoster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseballRosterExists(baseballRoster.Id))
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
            return View(baseballRoster);
        }

        // GET: BaseballRosters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BaseballRoster == null)
            {
                return NotFound();
            }

            var baseballRoster = await _context.BaseballRoster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baseballRoster == null)
            {
                return NotFound();
            }

            return View(baseballRoster);
        }

        // POST: BaseballRosters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BaseballRoster == null)
            {
                return Problem("Entity set 'SportsRostersContext.BaseballRoster'  is null.");
            }
            var baseballRoster = await _context.BaseballRoster.FindAsync(id);
            if (baseballRoster != null)
            {
                _context.BaseballRoster.Remove(baseballRoster);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaseballRosterExists(int id)
        {
          return _context.BaseballRoster.Any(e => e.Id == id);
        }
    }
}
