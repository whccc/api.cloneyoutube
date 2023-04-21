using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using api.cloneyoutube.Entity;

namespace api.cloneyoutube.Model
{
    public class DBContextApp : DbContext
    {

        public DbSet<UserEntity> User { get; set; }
        public DbSet<VideoEntity> Video { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseOracle(configuration.GetConnectionString("OracleConnection"));

        }
    }

}
