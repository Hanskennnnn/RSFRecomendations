using Microsoft.EntityFrameworkCore;
using RSFRecomendations.Configurates;
using RSFRecomendations.Configurations;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    /// <summary>
    /// Класс базы данных
    /// </summary>
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public MyDBContext()
        {

        }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<ProgrammingLanguageModel> ProgrammingLanguages { get; set; }

        public DbSet<ProgrammingLanguagePurposeModel> ProgrammingLanguagePurpose { get; set; }

        public DbSet<UserProgrammingLanguageModel> UserProgrammingLanguages { get; set; }

        public DbSet<FormModel> FormModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProgrammingLanguagePurposeConfiguration());
            modelBuilder.ApplyConfiguration(new UserProgrammingLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new FormModelConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Recomendationsdb;Username=postgres;Password=postgres");
            }
        }
    }
}