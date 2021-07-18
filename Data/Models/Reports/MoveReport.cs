using System.ComponentModel.DataAnnotations.Schema;
using SIV_Pokemons_LL.Models.Base;

namespace SIV_Pokemons_LL.Models.Reports
{
    public class MoveReport : BaseEntity
    {
        [Column("trainer_id")]
        public int TrainerId { get; set; }

        [Column("cell_from_id")]
        public int CellFromId { get; set; }

        [Column("cell_to_id")]
        public int CellToId { get; set; }

        [Column("theme_level")]
        public int? ThemeLevel { get; set; }

        [Column("pokemon_id")]
        public int? PokemonId { get; set; }

        [Column("book_report")]
        public string? BookReport { get; set; }

        [Column("book_for_read")]
        public string? BookForRead{ get; set; }

        [Column("actions")]
        public string? Actions { get; set; }

        public Trainer Trainer { get; set; }
        public Pokemon? Pokemon { get; set; }
        public Cell CellFrom { get; set; }
        public Cell CellTo { get; set; }

    }
}
