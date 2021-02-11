using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentskaSluzba.Data;
using StudentskaSluzba.Models;

namespace StudentskaSluzba.Controllers
{
    public class PredmetsController : Controller
    {
        static List<Predmet> predmeti = new List<Predmet>()
        {
            new Predmet(name: "OOAD", points: 5.0),
            new Predmet(name: "AFJ", points: 5.0),
            new Predmet(name: "ORM", points: 5.0),
            new Predmet(name: "RA", points: 5.0)
        };

        public PredmetsController(StudentskaSluzbaContext context)
        {
            
        }

        // GET: Predmets
        public IActionResult Index()
        {
            return View(predmeti);
        }

        // GET: Predmets/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = predmeti.FirstOrDefault(m => m.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // GET: Predmets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Predmets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Naziv,ECTS")] Predmet predmet)
        {
            if (ModelState.IsValid)
            {
                predmeti.Add(predmet);
                return RedirectToAction(nameof(Index));
            }
            return View(predmet);
        }

        // GET: Predmets/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = predmeti.Find(p => p.ID == id);
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
        public IActionResult Edit(int id, [Bind("ID,Naziv,ECTS")] Predmet predmet)
        {
            if (id != predmet.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var stariPredmet = predmeti.Find(p => p.ID == id);
                    stariPredmet.ID = predmet.ID;
                    stariPredmet.Naziv = predmet.Naziv;
                    stariPredmet.ECTS = predmet.ECTS;
                    stariPredmet.UpisaniStudenti = predmet.UpisaniStudenti;
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
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predmet = predmeti.FirstOrDefault(m => m.ID == id);
            if (predmet == null)
            {
                return NotFound();
            }

            return View(predmet);
        }

        // POST: Predmets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var predmet = predmeti.Find(p => p.ID == id);
            predmeti.Remove(predmet);
            return RedirectToAction(nameof(Index));
        }

        private bool PredmetExists(int id)
        {
            return predmeti.Any(e => e.ID == id);
        }
    }
}
