using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppForWorkingWithXML.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressObjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypeName = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    OperTypeId = table.Column<int>(nullable: false),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActual = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressObjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressObjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    ApartType = table.Column<int>(nullable: false),
                    OperTypeId = table.Column<long>(nullable: false),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActual = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsAddrObjDivisionItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ParentId = table.Column<long>(nullable: false),
                    ChildId = table.Column<long>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsAddrObjDivisionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsAdmHierarchyItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ParentObjId = table.Column<long>(nullable: true),
                    ParentObjIdSpecified = table.Column<bool>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    RegionCode = table.Column<string>(nullable: true),
                    AreaCode = table.Column<string>(nullable: true),
                    CityCode = table.Column<string>(nullable: true),
                    PlaceCode = table.Column<string>(nullable: true),
                    PlanCode = table.Column<string>(nullable: true),
                    StreetCode = table.Column<string>(nullable: true),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsAdmHierarchyItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsChangeHistoryItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeId = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    AdrObjectId = table.Column<Guid>(nullable: false),
                    OperTypeId = table.Column<int>(nullable: false),
                    NDocId = table.Column<long>(nullable: true),
                    NDocIdSpecified = table.Column<bool>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsChangeHistoryItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsMunHierarchyItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ParentObjId = table.Column<long>(nullable: true),
                    ParentObjIdSpecified = table.Column<bool>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    Oktmo = table.Column<string>(nullable: true),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsMunHierarchyItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carplaces",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    OperTypeId = table.Column<int>(nullable: false),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActual = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carplaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    HouseNum = table.Column<string>(nullable: true),
                    AddNum1 = table.Column<string>(nullable: true),
                    AddNum2 = table.Column<string>(nullable: true),
                    HouseType = table.Column<int>(nullable: true),
                    AddType1 = table.Column<int>(nullable: true),
                    AddType2 = table.Column<int>(nullable: true),
                    OperTypeId = table.Column<int>(nullable: false),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActual = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NormativeDocs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Kind = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    OrgName = table.Column<string>(nullable: true),
                    RegNum = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: true),
                    RegDateSpecified = table.Column<bool>(nullable: false),
                    AccDate = table.Column<DateTime>(nullable: true),
                    AccDateSpecified = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NormativeDocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NormativeDocsKinds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NormativeDocsKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NormativeDocsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NormativeDocsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjectLevels",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Params",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ChangeId = table.Column<long>(nullable: true),
                    ChangeIdSpecified = table.Column<bool>(nullable: false),
                    ChangeIdEnd = table.Column<long>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Params", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParamTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParamTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReestrObjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectId = table.Column<long>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    LevelId = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReestrObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    RoomType = table.Column<int>(nullable: false),
                    OperTypeId = table.Column<int>(nullable: false),
                    PrevId = table.Column<long>(nullable: true),
                    PrevIdSpecified = table.Column<bool>(nullable: false),
                    NextId = table.Column<long>(nullable: true),
                    NextIdSpecified = table.Column<bool>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActual = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Steads",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ObjectId = table.Column<long>(nullable: false),
                    ObjectGuid = table.Column<Guid>(nullable: false),
                    ChangeId = table.Column<long>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    OperTypeId = table.Column<int>(nullable: false),
                    PrevId = table.Column<long>(nullable: true),
                    NextId = table.Column<long>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActual = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steads", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressObjects");

            migrationBuilder.DropTable(
                name: "AddressObjectTypes");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "ApartmentTypes");

            migrationBuilder.DropTable(
                name: "AsAddrObjDivisionItems");

            migrationBuilder.DropTable(
                name: "AsAdmHierarchyItems");

            migrationBuilder.DropTable(
                name: "AsChangeHistoryItems");

            migrationBuilder.DropTable(
                name: "AsMunHierarchyItems");

            migrationBuilder.DropTable(
                name: "Carplaces");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "HouseTypes");

            migrationBuilder.DropTable(
                name: "NormativeDocs");

            migrationBuilder.DropTable(
                name: "NormativeDocsKinds");

            migrationBuilder.DropTable(
                name: "NormativeDocsTypes");

            migrationBuilder.DropTable(
                name: "ObjectLevels");

            migrationBuilder.DropTable(
                name: "OperationTypes");

            migrationBuilder.DropTable(
                name: "Params");

            migrationBuilder.DropTable(
                name: "ParamTypes");

            migrationBuilder.DropTable(
                name: "ReestrObjects");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "Steads");
        }
    }
}
