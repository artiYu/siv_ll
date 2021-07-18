using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SIV_Pokemons_LL.Models.Reports;

namespace SIV_Pokemons_LL.Models
{
    [Table("Trainer")]
    public class Trainer
    {
        [Column("id")]
        [Key]
        public int Id { get; }

        [Column("nickname")]
        public string Nickname { get; }

        public List<Journal> Journals { get; set; }
        public List<MoveReport> MoveReports { get; set; }
    }
}
