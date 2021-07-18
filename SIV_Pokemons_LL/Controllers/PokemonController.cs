using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIV_Pokemons_LL.Business.Models.DTO;
using SIV_Pokemons_LL.Models;
using SIV_Pokemons_LL.Services;

namespace SIV_Pokemons_LL.Controllers
{
    public class PokemonController : Controller
    {
        private readonly SivContext context;
        private readonly IMapper mapper;

        public PokemonController(IMapper mapper)
        {
            this.mapper = mapper;
            context = new SivContext(new PokemonsContext(), this.mapper);
        }

        // GET: Pokemon
        public IActionResult Index()
        {
            var pokemons = context.PokemonRepository.GetAllP();
            return View(mapper.Map<IEnumerable<PokemonDTO>>(pokemons));
        }

        //GET: Pokemon/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = context.PokemonRepository.Get((int)id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // GET: Pokemon/Create
        /*public async Task<IActionResult> Create()
        {
            //TODO: вместо ViewBag - отдельные модели для представлений
            ViewBag.Types = new SelectList(await context.TypeRepository.GetAll(), "Id", "Name");
            ViewBag.Pokemons = new SelectList(await context.PokemonRepository.GetAll(), "Id", "Name");
            return View();
        }*/

        // POST: Pokemon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      /*  [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TypesId,Type1Id,Type2Id,EvolutionParent,EvolutionNumber,InitForm,EvolveFrom,EvolveTo,EvolveWith,IsMega")] PokemonDTO pokemon)
        {
            pokemon.Type2Id = pokemon.Type2Id ?? 1;
            pokemon.EvolutionNumber = pokemon.EvolutionNumber == 0 ? 1 : pokemon.EvolutionNumber;

            if (ModelState.IsValid)
            {
                var createdPokemon = context.PokemonRepository.Insert(pokemon);
                await context.SaveAsync();

                pokemon.InitForm = pokemon.EvolutionNumber == 1 ? createdPokemon.Id : pokemon.InitForm;

                context.PokemonRepository.Update(pokemon);
                await context.SaveAsync();

                if (!(pokemon.EvolveFrom is null))
                {
                    var parentPokemon = await context.PokemonRepository.Get((int)pokemon.EvolveFrom);
                    parentPokemon.EvolveTo = pokemon.Id.ToString();
                    context.PokemonRepository.Update(parentPokemon);
                    await context.SaveAsync();
                }


                return RedirectToAction(nameof(Index));
            }
            ViewBag.Types = new SelectList(await context.TypeRepository.GetAll(), "Id", "Name");
            ViewBag.Pokemons = new SelectList(await context.PokemonRepository.GetAll(), "Id", "Name");
            return View(pokemon);
        }*/

        // GET: Pokemon/Edit/5
       /* public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            ViewData["Type1Id"] = new SelectList(_context.Types, "Id", "Id", pokemon.Type1Id);
            ViewData["Type2Id"] = new SelectList(_context.Types, "Id", "Id", pokemon.Type2Id);
            return View(pokemon);
        }*/

        // POST: Pokemon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,TypesId,Type1Id,Type2Id,EvolutionParent,EvolutionNumber,InitForm,EvolveFrom,EvolveTo,EvolveWith,IsMega")] Pokemon pokemon)
        //{
        //    if (id != pokemon.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(pokemon);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PokemonExists(pokemon.Id))
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
        //    ViewData["Type1Id"] = new SelectList(_context.Types, "Id", "Id", pokemon.Type1Id);
        //    ViewData["Type2Id"] = new SelectList(_context.Types, "Id", "Id", pokemon.Type2Id);
        //    return View(pokemon);
        //}

        // GET: Pokemon/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pokemon = await _context.Pokemons
        //        .Include(p => p.Type_1)
        //        .Include(p => p.Type_2)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (pokemon == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pokemon);
        //}

        // POST: Pokemon/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var pokemon = await _context.Pokemons.FindAsync(id);
        //    _context.Pokemons.Remove(pokemon);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PokemonExists(int id)
        //{
        //    return _context.Pokemons.Any(e => e.Id == id);
        //}
    }
}
