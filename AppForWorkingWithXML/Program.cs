using AppForWorkingWithXML.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace AppForWorkingWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MainContext context = new MainContext();
            context.Database.Migrate();             
            
        }
    }
}
