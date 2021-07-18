using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIV_Pokemons_LL.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("region_id")]
        public int RegionId { get; set; }

        [Column("types_id")]
        public string? TypesId { get; set; }

        [Column("pokemons_meet_id")]
        public string? PokemonsMeetId { get; set; }
    }
}
