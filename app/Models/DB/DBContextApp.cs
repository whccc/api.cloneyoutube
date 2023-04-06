using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace api.cloneyoutube.Model
{
    public class DBContextApp : DbContext
    {

        public DbSet<UserModel> Users { get; set; }

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
