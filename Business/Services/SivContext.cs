using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Services.Interfaces;
using SIV_Pokemons_LL.Services.Repositories;

namespace SIV_Pokemons_LL.Services
{
    public class SivContext : ISivContext
    {
        protected DbContext context;
        protected IMapper mapper;
        public PokemonRepository PokemonRepository { get; }
        //public TypeRepository TypeRepository { get; }
        public CellRepository CellRepository { get; }
        //public LocationRepository LocationRepository { get; }
        public MoveReportRepository MoveReportRepository { get; }

        public SivContext(DbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
            PokemonRepository = new PokemonRepository(context, mapper);
           // TypeRepository = new TypeRepository(context, mapper);
           // CellRepository = new CellRepository(context, mapper);
            //LocationRepository = new LocationRepository(context, mapper);
            MoveReportRepository = new MoveReportRepository(context, mapper);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
