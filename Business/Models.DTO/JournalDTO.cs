namespace SIV_Pokemons_LL.Business.Models.DTO
{
    public class JournalDTO
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public int? CellFromId { get; set; }
        public int? CellToId { get; set; }
        public string Book { get; set; }
        public int PokemonId { get; set; }
        public int EventId { get; set; }
        public string Actions { get; set; }
    }
}
