using System.Collections.Generic;
using SIV_Pokemons_LL.Business.Models.DTO;
using SIV_Pokemons_LL.Models;

namespace SIV_Pokemons_LL.Business
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateMap<Pokemon, PokemonDTO>();
        }
    }
}
