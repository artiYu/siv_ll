using Microsoft.EntityFrameworkCore;
using SIV_Pokemons_LL.Models.Reports;

namespace SIV_Pokemons_LL.Models
{
    public class PokemonsContext : DbContext
    {
        public DbSet<Pokedex> Pokedexes { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<MoveReport> MoveReport { get; set; }

        public PokemonsContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public PokemonsContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainer>()
                        .HasKey(t => t.Id);

            modelBuilder.Entity<Location>()
                        .HasKey(t => t.Id);

            modelBuilder.Entity<Pokedex>()
                        .HasOne(p => p.Pokemon)
                        .WithMany(p => p.Pokedexes)
                        .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<Pokemon>()
                        .HasOne(p => p.Type_1)
                        .WithMany(p => p.Pokemons_1)
                        .HasForeignKey(p => p.Type1Id);

            modelBuilder.Entity<Pokemon>()
                        .HasOne(p => p.Type_2)
                        .WithMany(p => p.Pokemons_2)
                        .HasForeignKey(p => p.Type2Id);

            modelBuilder.Entity<Journal>()
                        .HasOne(p => p.Pokemon)
                        .WithMany(p => p.Journals)
                        .HasForeignKey(p => p.PokemonId);

            modelBuilder.Entity<Journal>()
                        .HasOne(p => p.Trainer)
                        .WithMany(p => p.Journals)
                        .HasForeignKey(p => p.TrainerId);

            modelBuilder.Entity<Journal>()
                        .HasOne(p => p.CellFrom)
                        .WithMany(p => p.JournalsFrom)
                        .HasForeignKey(p => p.CellFromId);

            modelBuilder.Entity<Journal>()
                        .HasOne(p => p.CellTo)
                        .WithMany(p => p.JournalsTo)
                        .HasForeignKey(p => p.CellToId);

            modelBuilder.Entity<MoveReport>()
                        .HasOne(p => p.CellFrom)
                        .WithMany(p => p.MoveReportsFrom)
                        .HasForeignKey(p => p.CellFromId);

            modelBuilder.Entity<MoveReport>()
                        .HasOne(p => p.CellTo)
                        .WithMany(p => p.MoveReportsTo)
                        .HasForeignKey(p => p.CellToId);
        }
    }
}
