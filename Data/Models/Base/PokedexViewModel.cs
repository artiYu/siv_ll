using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SIV_Pokemons_LL.Models
{
    public class PokedexViewModel
    {
        public List<Pokedex> PokedexActive { get; set; }
        public List<Pokedex> PokedexCollection { get; set; }
        public Dictionary<int, List<Pokedex>> PokemonsByEvolutions { get; set; }
    }
}
