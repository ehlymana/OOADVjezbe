using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentskaSluzba.Models;
using StudentskaSluzbaAuthorization.Data;

namespace StudentskaSluzbaAuthorization.Controllers
{
    [Authorize]
    public class PredmetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PredmetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Predmets
        [Authorize(Roles = "Administrator, Korisnik")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Predmet.ToListAsync());
        }

        // GET: Predmets/Details/5
        [Authorize(Roles = "Administrator, Korisnik")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = await _context.Predmet
                .FirstOrDefaultAsync(m => m.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // GET: Predmets/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Predmets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("ID,Naziv,ECTS")] Predmet predmet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(predmet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(predmet);
        }

        // GET: Predmets/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = await _context.Predmet.FindAsync(id);
            if (predmet == null)
            {
                return NotFound();
            }
            return View(predmet);
        }

        // POST: Predmets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Naziv,ECTS")] Predmet predmet)
        {
            if (id != predmet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(predmet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredmetExists(predmet.ID))
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
            return View(predmet);
        }

        // GET: Predmets/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = await _context.Predmet
                .FirstOrDefaultAsync(m => m.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // POST: Predmets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var predmet = await _context.Predmet.FindAsync(id);
            _context.Predmet.Remove(predmet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredmetExists(int id)
        {
            return _context.Predmet.Any(e => e.ID == id);
        }
    }
}
