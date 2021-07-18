using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIV_Pokemons_LL.Models
{
    [Table("Type")]
    public class Type
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public List<Pokemon> Pokemons_1 { get; set; }
        public List<Pokemon> Pokemons_2 { get; set; }
    }
}
