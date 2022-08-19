using Microsoft.EntityFrameworkCore;


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

        public MainContext CreateDbContext()
        {            
            return new MainContext(_options);
        }
    }
}
