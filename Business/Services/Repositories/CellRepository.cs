using AutoMapper;
using SIV_Pokemons_LL.Business.Models.DTO;
using SIV_Pokemons_LL.Models;
using SIV_Pokemons_LL.Services.Interfaces;

namespace SIV_Pokemons_LL.Services.Repositories
{
    public class CellRepository : Repository<Cell, CellDTO>, ICellRepository
    {
        public CellRepository(PokemonsContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
