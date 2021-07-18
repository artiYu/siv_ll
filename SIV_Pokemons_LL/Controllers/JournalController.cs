using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Models;

namespace SIV_Pokemons_LL.Controllers
{
    public class JournalController : Controller
    {
        private readonly PokemonsContext _context;

        public JournalController(PokemonsContext context)
        {
            _context = context;
        }

        // GET: Journal
      /*  public async Task<IActionResult> Index()
        {
            var cells = await _context.Cells.ToListAsync();
            var journals = await _context.Journals
                .Include(j => j.CellFrom)
                .Include(j => j.CellTo)
                .Include(j => j.Trainer)
                .Include(j => j.Pokemon)
                .ToListAsync();

            return View(new JournalViewModel() { Cells = cells, Journals = journals});
        }

        // GET: Journal/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journal = await _context.Journals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journal == null)
            {
                return NotFound();
            }

            return View(journal);
        }

        // GET: Journal/Create
        public IActionResult Create()
        {
            ViewBag.Cells = new SelectList(_context.Cells, "Id", "Name");

            //TODO with trainerId
            ViewBag.TrainerPokemons = new SelectList(_context.Pokedexes
                .Include(p => p.Pokemon)
                .Where(p => p.TrainerId == 1)
                .Select(p => p.Pokemon), "Id", "Name");

            return View();
        }

        // POST: Journal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CellFromId,CellToId,Book,PokemonId,EventId,Actions")] Journal journal)
        {
            if (ModelState.IsValid)
            {
                //TODO
                journal.TrainerId = 1;
                _context.Journals.Add(journal);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(journal);
        }

        // GET: Journal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journal = await _context.Journals.FindAsync(id);
            if (journal == null)
            {
                return NotFound();
            }
            return View(journal);
        }

        // POST: Journal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TrainerId,CellFrom,CellTo,Book,PokemonId,EventId,Actions")] JournalDTO journal)
        {
            if (id != journal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(journal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JournalExists(journal.Id))
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
            return View(journal);
        }

        // GET: Journal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var journal = await _context.Journals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (journal == null)
            {
                return NotFound();
            }

            return View(journal);
        }

        // POST: Journal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var journal = await _context.Journals.FindAsync(id);
            _context.Journals.Remove(journal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JournalExists(int id)
        {
            return _context.Journals.Any(e => e.Id == id);
        }*/
    }
}
