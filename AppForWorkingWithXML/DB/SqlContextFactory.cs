using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForWorkingWithXML.DB
{
    public class SqlContextFactory 
    {
       
        private DbContextOptions<MainContext> _options;

        public SqlContextFactory(string connString)
        {

            _options = new DbContextOptionsBuilder<MainContext>()
                        .UseSqlServer(connString).Options;
        }

        public MainContext CreateContext()
        {
            return new MainContext(_options);
        }
    }
}
