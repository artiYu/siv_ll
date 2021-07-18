using System.Collections.Generic;
using SIV_Pokemons_LL.Business.Models.DTO;
using SIV_Pokemons_LL.Models;

namespace SIV_Pokemons_LL.Services.Interfaces
{
    public interface IPokemonRepository : IRepository<Pokemon, PokemonDTO>
    {
         IEnumerable<Pokemon> GetAllP();
    }
}
