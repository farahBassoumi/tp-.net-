using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using tp.Models;

namespace tp.Data
{
    public class ApplicationDBContext : DbContext
    {




        public ApplicationDBContext(DbContextOptions options)
        : base(options)
        {


        }
        public DbSet<Movies> movies { get; set; }
        public DbSet<Genres> genres { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Membershiptype> Membershiptype { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data from JSON file
            SeedGenres(modelBuilder);
        }

        private void SeedGenres(ModelBuilder modelBuilder)
        {
            // Read JSON file
            var jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SeedData/genres.json");
            var jsonData = File.ReadAllText(jsonPath);

            // Deserialize JSON data
            var genres = JsonConvert.DeserializeObject<List<Genres>>(jsonData);

            // Seed data
            modelBuilder.Entity<Genres>().HasData(genres);
        }


    }
}
