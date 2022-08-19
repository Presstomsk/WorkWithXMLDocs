using AppForWorkingWithXML.Models.AS.ADDR.OBJ;
using AppForWorkingWithXML.Models.AS.ADDR.OBJ.DIVISION;
using AppForWorkingWithXML.Models.AS.ADDR.TYPES;
using AppForWorkingWithXML.Models.AS.APARTMENT.TYPES;
using AppForWorkingWithXML.Models.AS.APARTMENTS;
using AppForWorkingWithXML.Models.AS.CARPLACES;
using AppForWorkingWithXML.Models.AS.HOUSE.TYPES;
using AppForWorkingWithXML.Models.AS.HOUSES;
using AppForWorkingWithXML.Models.AS.NORMATIVE.DOCS;
using AppForWorkingWithXML.Models.AS.NORMATIVE.DOCS.KINDS;
using AppForWorkingWithXML.Models.AS.NORMATIVE.DOCS.TYPES;
using AppForWorkingWithXML.Models.AS.OBJECT.LEVELS;
using AppForWorkingWithXML.Models.AS.OPERATION.TYPES;
using AppForWorkingWithXML.Models.AS.PARAM;
using AppForWorkingWithXML.Models.AS.PARAM.TYPES;
using AppForWorkingWithXML.Models.AS.REESTR.OBJECTS;
using AppForWorkingWithXML.Models.AS.ROOM.TYPES;
using AppForWorkingWithXML.Models.AS.ROOMS;
using AppForWorkingWithXML.Models.AS.STEADS;
using Microsoft.EntityFrameworkCore;


namespace AppForWorkingWithXML.DB
{
    public class MainContext : DbContext
    {

        public DbSet<ADDRESSOBJECTS> AddressObdjects { get; set; }
        public DbSet<ITEMS> Items { get; set; }
        public DbSet<ADDRESSOBJECTTYPES> AddressObjectTypes { get; set; }
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
        public DbSet<STEADS> Steads { get; set; }


        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
           
        }

        
    }
}
