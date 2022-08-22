using AppForWorkingWithXML.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppForWorkingWithXML.DB
{
    public class MainContext : DbContext
    { 
                
        public DbSet<AddressObjectsObject> AddressObjects { get; set; }

        
        public MainContext(){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .Build();
            var connString = config.GetConnectionString("MainDb");
            optionsBuilder.UseSqlServer(connString);
        }
    }       
    
}
