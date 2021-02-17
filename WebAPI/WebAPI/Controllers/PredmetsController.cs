using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using WebAPI;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredmetsController : ControllerBase
    {
        private readonly StudentskaSluzbaContext _context;

        public PredmetsController(StudentskaSluzbaContext context)
        {
            _context = context;
        }

        // GET: api/Predmets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Predmet>>> GetPredmets()
        {
            return await _context.Predmets.ToListAsync();
        }

        // GET: api/Predmets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Predmet>> GetPredmet(int id)
        {
            var predmet = await _context.Predmets.FindAsync(id);

            if (predmet == null)
            {
                return NotFound();
            }

            return predmet;
        }

        // GET: api/NapuniBazu/5
        [HttpGet("NapuniBazu/{redovi}")]
        public async Task<ActionResult> NapuniBazu(int redovi)
        {
            string eksterniAPI = "https://ois2.ut.ee/api/courses/";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(eksterniAPI);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage odgovor = await client.GetAsync("?take=" + redovi);
                if (odgovor.IsSuccessStatusCode)
                {
                    var json = await odgovor.Content.ReadAsStringAsync();
                    dynamic podaci = JArray.Parse(json);
                    foreach (var kurs in podaci)
                    {
                        string ime = kurs["title"]["en"];
                        double ECTS = kurs["credits"];
                        Random generator = new Random();
                        int id = 0;
                        for (int i = 0; i < 10; i++) id += (int)Math.Pow(10, i) * generator.Next(0, 9);
                        _context.Predmets.Add((new Predmet() { Naziv = ime, Ects = ECTS, Id = id }));
                    }
                    await _context.SaveChangesAsync();
                }
                else
                    return NotFound();
            }
            return NoContent();
        }

        // PUT: api/Predmets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPredmet(int id, Predmet predmet)
        {
            if (id != predmet.Id)
            {
                return BadRequest();
            }

            _context.Entry(predmet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PredmetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Predmets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Predmet>> PostPredmet(Predmet predmet)
        {
            _context.Predmets.Add(predmet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPredmet", new { id = predmet.Id }, predmet);
        }

        // DELETE: api/Predmets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Predmet>> DeletePredmet(int id)
        {
            var predmet = await _context.Predmets.FindAsync(id);
            if (predmet == null)
            {
                return NotFound();
            }

            _context.Predmets.Remove(predmet);
            await _context.SaveChangesAsync();

            return predmet;
        }

        private bool PredmetExists(int id)
        {
            return _context.Predmets.Any(e => e.Id == id);
        }
    }
}
