using AppForWorkingWithXML.DB;
using Microsoft.Extensions.Configuration;
using System;

namespace AppForWorkingWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")                 
                        .Build();
            var connString = config.GetConnectionString("MainDb");

            var contextFactory = new SqlContextFactory(connString);
            using (var context = contextFactory.CreateDbContext())
            { }
            
        }
    }
}
