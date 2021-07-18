using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SIV_Pokemons_LL.Models.Reports;

namespace SIV_Pokemons_LL.Models
{
    [Table("Pokemon")]
    public class Pokemon : IComparable<Pokemon>
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        //TODO: required
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Column("type_1")]
        public int Type1Id { get; set; }

        [Column("type_2")]
        public int? Type2Id { get; set; }

        [Column("evolution_number")]
        public int EvolutionNumber { get; set; }

        [Column("init_form")]
        public int? InitForm { get; set; }

        [Column("evolve_from")]
        public int? EvolveFrom { get; set; }

        [Column("evolve_to")]
        public string? EvolveTo { get; set; }

        [Column("evolve_with")]
        public string? EvolveWith { get; set; }

        [Column("is_mega")]
        public int IsMega { get; set; }

        public List<Pokedex> Pokedexes { get; set; }
        public List<Journal> Journals { get; set; }
        public List<MoveReport> MoveReports { get; set; }
        public Type Type_1 { get; set; }
        public Type Type_2 { get; set; }

        public int CompareTo(Pokemon other)
        {
            if (other is null)
            {
                return 1;
            }
            return EvolutionNumber.CompareTo(other.EvolutionNumber);
        }
    }
}
