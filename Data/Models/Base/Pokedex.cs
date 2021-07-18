using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIV_Pokemons_LL.Models
{
    [Table("Pokedex")]
    public class Pokedex : IComparable<Pokedex>
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("trainer_id")]
        public int TrainerId { get; set; }

        [Column("pokemon_id")]
        public int PokemonId { get; set; }

        [Column("pokemon_level")]
        public int PokemonLevel { get; set; }

        [Column("pokemon_exp")]
        public int PokemonExp { get; set; }

        [Column("pokemon_is_active")]
        public int PokemonIsActive { get; set; }

        public Pokemon Pokemon { get; set; }

        public int CompareTo(Pokedex other)
        {
            if (other is null)
            {
                return 1;
            }
            return Pokemon.CompareTo(other.Pokemon);
        }
    }
}
