using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Models;
using SIV_Pokemons_LL.Services;

namespace SIV_Pokemons_LL.Controllers
{
    public class MoveReportController : Controller
    {
        private readonly SivContext context = new SivContext(new PokemonsContext(), mapper);
        private static IMapper mapper;

        public MoveReportController(IMapper mapper)
        {
            MoveReportController.mapper = mapper;
        }

        // GET: MoveReports
       /* public async Task<IActionResult> Index()
        {
            var moveReports = context.MoveReportRepository.GetAll();
            return View(await moveReports);
        }

        // GET: MoveReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moveReport = await context.MoveReportRepository.Get((int)id);
            if (moveReport == null)
            {
                return NotFound();
            }

            return View(moveReport);
        }

        // GET: MoveReports/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.Cells = new SelectList(await context.CellRepository.GetAll(), "Id", "Name");
            return View();
        }

        // POST: MoveReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      /*  [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TrainerId,CellFromId,CellToId,ThemeLevel,Book,Actions,Id")] MoveReport moveReport)
        {
            if (ModelState.IsValid)
            {
                context.MoveReportRepository.Insert(moveReport);
                await context.SaveAsync();
                ViewBag.Cells = new SelectList(await context.CellRepository.GetAll(), "Id", "Name");
                return RedirectToAction(nameof(Index));
            }

            return View(moveReport);
        }*/

        // GET: MoveReports/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var moveReport = await _context.MoveReports.FindAsync(id);
        //    if (moveReport == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["TrainerId"] = new SelectList(_context.Set<Trainer>(), "Id", "Id", moveReport.TrainerId);
        //    return View(moveReport);
        //}

        // POST: MoveReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("TrainerId,CellFromId,CellToId,ThemeLevel,Book,Actions,Id")] MoveReport moveReport)
        //{
        //    if (id != moveReport.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(moveReport);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!MoveReportExists(moveReport.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["TrainerId"] = new SelectList(_context.Set<Trainer>(), "Id", "Id", moveReport.TrainerId);
        //    return View(moveReport);
        //}

        // GET: MoveReports/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var moveReport = await _context.MoveReports
        //        .Include(m => m.Trainer)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (moveReport == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(moveReport);
        //}

        // POST: MoveReports/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var moveReport = await _context.MoveReports.FindAsync(id);
        //    _context.MoveReports.Remove(moveReport);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool MoveReportExists(int id)
        //{
        //    return _context.MoveReports.Any(e => e.Id == id);
        //}*/
    }
}
