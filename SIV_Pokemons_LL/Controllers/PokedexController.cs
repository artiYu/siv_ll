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
    public class PokedexController : Controller
    {
        private readonly PokemonsContext _context;

        public PokedexController(PokemonsContext context)
        {
            _context = context;
        }

        // GET: Pokedex
        /*public async Task<IActionResult> Index()
        { 
            var pokedexCollection = await _context.Pokedexes
                                .Include(p => p.Pokemon)
                                .ThenInclude(p => p.Type_1)
                                .Include(p => p.Pokemon)
                                .ThenInclude(p => p.Type_2)
                                .Where(p => p.PokemonIsActive == 0).ToListAsync();

            Dictionary<int, List<Pokedex>> pokemonsByEvolutions = new Dictionary<int, List<Pokedex>>();

            for (int i = 0; i < pokedexCollection.Count; i++)
            {
                int? evolutionParent = pokedexCollection[i].Pokemon.EvolutionParent;
                int pokemonId = pokedexCollection[i].Pokemon.Id;
                var value = pokedexCollection[i];

                if (evolutionParent == pokemonId)
                {
                    if (!pokemonsByEvolutions.ContainsKey(pokemonId))
                    {
                        pokemonsByEvolutions.Add(pokemonId, new() { value });
                    }
                    else
                    {
                        pokemonsByEvolutions[pokemonId].Add(value);
                    }
                }
                else
                {
                    if (!pokemonsByEvolutions.ContainsKey((int)evolutionParent))
                    {
                        pokemonsByEvolutions.Add((int)evolutionParent, new() { value });
                    }
                    else
                    {
                        pokemonsByEvolutions[(int)evolutionParent].Add(value);
                    }
                }
            }

            foreach (var item in pokemonsByEvolutions)
            {
                item.Value.Sort();
            }
            

            var pokedexViewModel = new PokedexViewModel()
            {
                PokedexActive = await _context.Pokedexes
                                .Include(p => p.Pokemon)
                                .ThenInclude(p => p.Type_1)
                                .Include(p => p.Pokemon)
                                .ThenInclude(p => p.Type_2)
                                .Where(p => p.PokemonIsActive == 1).ToListAsync(),

                PokedexCollection = await _context.Pokedexes
                                .Include(p => p.Pokemon)
                                .ThenInclude(p => p.Type_1)
                                .Include(p => p.Pokemon)
                                .ThenInclude(p => p.Type_2)
                                .Where(p => p.PokemonIsActive == 0).ToListAsync(),

                PokemonsByEvolutions = pokemonsByEvolutions
            };
            return View(pokedexViewModel);
        }

        // GET: Pokedex/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokedex = await _context.Pokedexes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokedex == null)
            {
                return NotFound();
            }

            return View(pokedex);
        }

        // GET: Pokedex/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pokedex/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TrainerId,PokemonId,PokemonLevel,PokemonExp,PokemonIsActive")] Pokedex pokedex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokedex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokedex);
        }

        // GET: Pokedex/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokedex = await _context.Pokedexes.FindAsync(id);
            if (pokedex == null)
            {
                return NotFound();
            }
            return View(pokedex);
        }

        // POST: Pokedex/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TrainerId,PokemonId,PokemonLevel,PokemonExp,PokemonIsActive")] Pokedex pokedex)
        {
            if (id != pokedex.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokedex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokedexExists(pokedex.Id))
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
            return View(pokedex);
        }

        // GET: Pokedex/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pokedex = await _context.Pokedexes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pokedex == null)
            {
                return NotFound();
            }

            return View(pokedex);
        }

        // POST: Pokedex/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pokedex = await _context.Pokedexes.FindAsync(id);
            _context.Pokedexes.Remove(pokedex);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokedexExists(int id)
        {
            return _context.Pokedexes.Any(e => e.Id == id);
        }*/
    }
}
