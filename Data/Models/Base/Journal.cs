using System.ComponentModel.DataAnnotations.Schema;
using SIV_Pokemons_LL.Models.Base;

namespace SIV_Pokemons_LL.Models
{
    [Table("Journal")]
    public class Journal
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("trainer_id")]
        public int TrainerId { get; set; }

        [Column("cell_from")]
        public int? CellFromId { get; set; }

        [Column("cell_to")]
        public int? CellToId { get; set; }

        [Column("book")]
        public string Book { get; set; }

        [Column("pokemon_id")]
        public int PokemonId { get; set; }

        [Column("event_id")]
        public int EventId { get; set; }

        [Column("actions")]
        public string Actions { get; set; }

        public Trainer Trainer { get; set; }
        public Cell? CellFrom { get; set; }
        public Cell? CellTo { get; set; }
        public Pokemon Pokemon { get; set; }

    }
}
