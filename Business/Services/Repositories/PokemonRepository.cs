using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Business.Models.DTO;
using SIV_Pokemons_LL.Models;
using SIV_Pokemons_LL.Services.Interfaces;

namespace SIV_Pokemons_LL.Services.Repositories
{
    public class PokemonRepository : Repository<Pokemon, PokemonDTO>, IPokemonRepository
    {
        public PokemonRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public IEnumerable<Pokemon> GetAllP()
        {
            var result = context.Set<Pokemon>().ToList();
            return result;
        }
    }
}
