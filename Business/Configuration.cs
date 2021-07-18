using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SIV_Pokemons_LL.Models;

namespace SIV_Pokemons_LL
{
    public static class Configuration
    {
        public static DbContextOptionsBuilder OptionsBuilder
        {
            get
            {
                return new DbContextOptionsBuilder<PokemonsContext>()
                    .UseSqlServer(ConnectionString);
            }
        }

        public static string ConnectionString
        {
            get
            {
                return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build()
                    .GetConnectionString("PokemonConnection");
            }
        }

    }
}
