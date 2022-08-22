using AppForWorkingWithXML.Models.Dto;

using Microsoft.EntityFrameworkCore;


namespace AppForWorkingWithXML.DB
{
    public class MainContext : DbContext
    { 
        
        
        public DbSet<AddressObjects> AddressObjects { get; set; }
        /*public DbSet<ADDRESSOBJECTTYPES> AddressObjectTypes { get; set; }
        public DbSet<Models.AS.ADM.HIERARCHY.ITEMS> ItemsAdmHierarchy { get; set; }
        public DbSet<APARTMENTTYPES> ApartmentTypes { get; set; }
        public DbSet<APARTMENTS> Apartments { get; set; }
        public DbSet<CARPLACES> Carplaces { get; set; }
        public DbSet<Models.AS.CHANGE.HISTORY.ITEMS> ItemsChangeHistory { get; set; }
        public DbSet<HOUSETYPES> HouseTypes { get; set; }
        public DbSet<HOUSES> Houses { get; set; }
        public DbSet<Models.AS.MUN.HIERARCHY.ITEMS> ItemsMunHierarchy { get; set; }
        public DbSet<NORMDOCS> NormDocs { get; set; }
        public DbSet<NDOCKINDS> NormDocsKinds { get; set; }
        public DbSet<NDOCTYPES> NormDocsTypes { get; set; }
        public DbSet<OBJECTLEVELS> ObjectLevels { get; set; }
        public DbSet<OPERATIONTYPES> OperationsTypes { get; set; }
        public DbSet<PARAMS> Params { get; set; }
        public DbSet<PARAMTYPES> ParamTypes { get; set; }
        public DbSet<REESTR_OBJECTS> ReestrObjects { get; set; }
        public DbSet<ROOMTYPES> RoomTypes { get; set; }
        public DbSet<ROOMS> Rooms { get; set; }
        public DbSet<STEADS> Steads { get; set; }*/


        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
           Database.EnsureCreated();
        }

        
    }
}
