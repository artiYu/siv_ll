using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SIV_Pokemons_LL.Models.Reports;

namespace SIV_Pokemons_LL.Models
{
    [Table("Cell")]
    public class Cell 
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        [Column("location_id")]
        public int LocationId { get; set; }

        [Column("theme_level")]
        public int ThemeLevel { get; set; }

        [Column("theme")]
        public string Theme { get; set; }

        [Column("description")]
        public string Description { get; set; }

        public List<Journal> JournalsFrom { get; set; }
        public List<Journal> JournalsTo { get; set; }
        public List<MoveReport> MoveReportsFrom { get; set; }
        public List<MoveReport> MoveReportsTo { get; set; }
    }
}
