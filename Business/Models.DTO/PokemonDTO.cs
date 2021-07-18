namespace SIV_Pokemons_LL.Business.Models.DTO
{
    public class PokemonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type1Id { get; set; }
        public int? Type2Id { get; set; }
        public int EvolutionNumber { get; set; }
        public int? InitForm { get; set; }
        public int? EvolveFrom { get; set; }
        public string? EvolveTo { get; set; }
        public string? EvolveWith { get; set; }
        public int IsMega { get; set; }
    }
}
