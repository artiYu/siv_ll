using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIV_Pokemons_LL.Services.Repositories;

namespace SIV_Pokemons_LL.Services.Interfaces
{
    public interface ISivContext : IDisposable
    {
        PokemonRepository PokemonRepository { get; }
        //TypeRepository TypeRepository { get; }
        CellRepository CellRepository { get; }
        //LocationRepository LocationRepository { get; }
        MoveReportRepository MoveReportRepository { get; }
        Task SaveAsync();
    }
}
