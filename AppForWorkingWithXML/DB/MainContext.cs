using AppForWorkingWithXML.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppForWorkingWithXML.DB
{
    public class MainContext : DbContext
    { 
                
        public DbSet<AddressObjectsObject> AddressObjects { get; set; }
        public DbSet<AsAddrObjDivisionItemsItem> AsAddrObjDivisionItems { get; set; }
        public DbSet<AddressObjectTypesAddressObjectType> AddressObjectTypes { get; set; }
        public DbSet<AsAdmHierarchyItemsItem> AsAdmHierarchyItems { get; set; }
        public DbSet<ApartmentsApartment> Apartments { get; set; }
        public DbSet<ApartmentTypesApartmentType> ApartmentTypes { get; set; }
        public DbSet<CarplacesCarplace> Carplaces { get; set; }
        public DbSet<AsChangeHistoryItemsItem> AsChangeHistoryItems { get; set; }
        public DbSet<HousesHouse> Houses { get; set; }
        public DbSet<HouseTypesHouseType> HouseTypes { get; set; }
        public DbSet<AsMunHierarchyItemsItem> AsMunHierarchyItems { get; set; }
        public DbSet<NormativeDocsNormativeDoc> NormativeDocs { get; set; }
        public DbSet<NormativeDocsKind> NormativeDocsKinds { get; set; }
        public DbSet<NormativeDocsType> NormativeDocsTypes { get; set; }
        public DbSet<ObjectLevelsObjectLevel> ObjectLevels { get; set; }
        public DbSet<OperationTypesOperationType> OperationTypes { get; set; }
        public DbSet<ParamsParam> Params { get; set; }
        public DbSet<ParamTypesParamType> ParamTypes { get; set; }
        public DbSet<ReestrObjectsObject> ReestrObjects { get; set; }
        public DbSet<RoomsRoom> Rooms { get; set; }
        public DbSet<RoomTypesRoomType> RoomTypes { get; set; }
        public DbSet<SteadsStead> Steads { get; set; }


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
