using AppForWorkingWithXML.DB;
using AppForWorkingWithXML.Models.Dto;
using AppForWorkingWithXML.Models.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AppForWorkingWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            var mapper = new Mapper(config);
            using (var db = new MainContext()) { db.Database.Migrate(); }

            //AsAddrObjDeserializeAndPutToDB("", mapper);
            //AsAddrObjDivisionDeserializeAndPutToDB("", mapper);
            //AsAddrObjTypesDeserializeAndPutToDB("", mapper);
            //AsAdmHierarchyDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_ADM_HIERARCHY_20220808_c37d5b97-3bf5-497a-be5f-0f51c85f6bba.XML", mapper);
            //AsApartmentTypesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_APARTMENT_TYPES_20220807_cb43c792-a6fe-48cb-a061-4a9e205b9b55.XML", mapper);
            //AsApartmentsDeserializeAndPutToDB("", mapper);
            //AsCarplacesDeserializeAndPutToDB("", mapper);
            //AsChangeHistoryDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_CHANGE_HISTORY_20220808_ff6fcb76-1cf8-4a2a-a294-ba262a2df795.XML", mapper);
            //AsHouseTypesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_HOUSE_TYPES_20220807_182f9256-d3db-46c9-b657-7e121871bcf5.XML", mapper);
            //AsHousesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_HOUSES_20220808_4bd5ba50-497d-476a-90df-ff7834f4b7c2.XML", mapper);
            //AsMunHierarchyDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_MUN_HIERARCHY_20220808_91eeeec5-a1d3-4f00-8a15-276edf7022e6.XML", mapper);
            //AsNormativeDocsDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_NORMATIVE_DOCS_20220808_bb7cce8f-b11b-4042-bbbf-40131ef2f054.XML", mapper);
            //AsNormativeDocsKindsDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_NORMATIVE_DOCS_KINDS_20220807_7ca74e59-5b92-400e-a813-bbf37aa79860.XML", mapper);
            //AsNormativeDocsTypesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_NORMATIVE_DOCS_TYPES_20220807_8556bde6-177c-437a-8caf-dbf32fc69408.XML", mapper);
            //AsObjectLevelsDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_OBJECT_LEVELS_20220807_b1201082-f74f-4dd8-aa68-b649275e66ff.XML", mapper);
            //AsOperationsTypesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_OPERATION_TYPES_20220807_1e192c36-3df0-4dba-88d7-5353a888ef69.XML", mapper);
            //AsParamDeserializeAndPutToDB(@"", mapper);
            //AsParamTypesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_PARAM_TYPES_20220807_f5f8e579-c6b9-4085-97f0-f49d67d87892.XML", mapper);
            //AsReestrObjectsDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_REESTR_OBJECTS_20220808_4bee8c72-044d-438d-b29e-3d3a51a7a24d.XML", mapper);
            //AsRoomTypesDeserializeAndPutToDB(@"C:\Users\user\Desktop\Рабочая\Docs\AS_ROOM_TYPES_20220807_21fd9a3d-9847-4d56-a9eb-f786a31c5cfe.XML", mapper);
            //AsRoomsDeserializeAndPutToDB("", mapper);
            //AsSteadsDeserializeAndPutToDB("", mapper);
        }

        static void AsAddrObjDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(ADDRESSOBJECTS));           
            var list = new List<AddressObjectsObject>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as ADDRESSOBJECTS;

                if (objects != null)
                {
                    foreach (var obj in objects.OBJECT)
                    {
                        var entity = mapper.Map<AddressObjectsObject>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
               foreach (var item in list)
                {
                    db.AddressObjects.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsAddrObjDivisionDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(ITEMS));
            var list = new List<AsAddrObjDivisionItemsItem>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as ITEMS;

                if (objects != null)
                {
                    foreach (var obj in objects.ITEM)
                    {
                        var entity = mapper.Map<AsAddrObjDivisionItemsItem>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.AsAddrObjDivisionItems.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsAddrObjTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(ADDRESSOBJECTTYPES));
            var list = new List<AddressObjectTypesAddressObjectType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as ADDRESSOBJECTTYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.ADDRESSOBJECTTYPE)
                    {
                        var entity = mapper.Map<AddressObjectTypesAddressObjectType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.AddressObjectTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsAdmHierarchyDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(Models.Dto.AsAdmHierarchy.ITEMS));
            var list = new List<AsAdmHierarchyItemsItem>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as Models.Dto.AsAdmHierarchy.ITEMS;

                if (objects != null)
                {
                    foreach (var obj in objects.ITEM)
                    {
                        var entity = mapper.Map<AsAdmHierarchyItemsItem>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.AsAdmHierarchyItems.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsApartmentTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(APARTMENTTYPES));
            var list = new List<ApartmentTypesApartmentType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as APARTMENTTYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.APARTMENTTYPE)
                    {
                        var entity = mapper.Map<ApartmentTypesApartmentType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.ApartmentTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsApartmentsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(APARTMENTS));
            var list = new List<ApartmentsApartment>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as APARTMENTS;

                if (objects != null)
                {
                    foreach (var obj in objects.APARTMENT)
                    {
                        var entity = mapper.Map<ApartmentsApartment>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.Apartments.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsCarplacesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(CARPLACES));
            var list = new List<CarplacesCarplace>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as CARPLACES;

                if (objects != null)
                {
                    foreach (var obj in objects.CARPLACE)
                    {
                        var entity = mapper.Map<CarplacesCarplace>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.Carplaces.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsChangeHistoryDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(Models.Dto.AsChangeHistory.ITEMS));
            var list = new List<AsChangeHistoryItemsItem>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as Models.Dto.AsChangeHistory.ITEMS;

                if (objects != null)
                {
                    foreach (var obj in objects.ITEM)
                    {
                        var entity = mapper.Map<AsChangeHistoryItemsItem>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.AsChangeHistoryItems.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsHouseTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(HOUSETYPES));
            var list = new List<HouseTypesHouseType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as HOUSETYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.HOUSETYPE)
                    {
                        var entity = mapper.Map<HouseTypesHouseType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.HouseTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsHousesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(HOUSES));
            var list = new List<HousesHouse>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as HOUSES;

                if (objects != null)
                {
                    foreach (var obj in objects.HOUSE)
                    {
                        var entity = mapper.Map<HousesHouse>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.Houses.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsMunHierarchyDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(Models.Dto.AsMunHierarchy.ITEMS));
            var list = new List<AsMunHierarchyItemsItem>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as Models.Dto.AsMunHierarchy.ITEMS;

                if (objects != null)
                {
                    foreach (var obj in objects.ITEM)
                    {
                        var entity = mapper.Map<AsMunHierarchyItemsItem>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.AsMunHierarchyItems.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsNormativeDocsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(NORMDOCS));
            var list = new List<NormativeDocsNormativeDoc>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as NORMDOCS;

                if (objects != null)
                {
                    foreach (var obj in objects.NORMDOC)
                    {
                        var entity = mapper.Map<NormativeDocsNormativeDoc>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.NormativeDocs.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsNormativeDocsKindsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(NDOCKINDS));
            var list = new List<NormativeDocsKind>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as NDOCKINDS;

                if (objects != null)
                {
                    foreach (var obj in objects.NDOCKIND)
                    {
                        var entity = mapper.Map<NormativeDocsKind>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.NormativeDocsKinds.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsNormativeDocsTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(NDOCTYPES));
            var list = new List<NormativeDocsType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as NDOCTYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.NDOCTYPE)
                    {
                        var entity = mapper.Map<NormativeDocsType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.NormativeDocsTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsObjectLevelsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(OBJECTLEVELS));
            var list = new List<ObjectLevelsObjectLevel>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as OBJECTLEVELS;

                if (objects != null)
                {
                    foreach (var obj in objects.OBJECTLEVEL)
                    {
                        var entity = mapper.Map<ObjectLevelsObjectLevel>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.ObjectLevels.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsOperationsTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(OPERATIONTYPES));
            var list = new List<OperationTypesOperationType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as OPERATIONTYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.OPERATIONTYPE)
                    {
                        var entity = mapper.Map<OperationTypesOperationType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.OperationTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsParamDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(PARAMS));
            var list = new List<ParamsParam>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as PARAMS;

                if (objects != null)
                {
                    foreach (var obj in objects.PARAM)
                    {
                        var entity = mapper.Map<ParamsParam>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.Params.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsParamTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(PARAMTYPES));
            var list = new List<ParamTypesParamType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as PARAMTYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.PARAMTYPE)
                    {
                        var entity = mapper.Map<ParamTypesParamType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.ParamTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsReestrObjectsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(REESTR_OBJECTS));
            var list = new List<ReestrObjectsObject>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as REESTR_OBJECTS;

                if (objects != null)
                {
                    foreach (var obj in objects.OBJECT)
                    {
                        var entity = mapper.Map<ReestrObjectsObject>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.ReestrObjects.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsRoomTypesDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(ROOMTYPES));
            var list = new List<RoomTypesRoomType>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as ROOMTYPES;

                if (objects != null)
                {
                    foreach (var obj in objects.ROOMTYPE)
                    {
                        var entity = mapper.Map<RoomTypesRoomType>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.RoomTypes.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsRoomsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(ROOMS));
            var list = new List<RoomsRoom>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as ROOMS;

                if (objects != null)
                {
                    foreach (var obj in objects.ROOM)
                    {
                        var entity = mapper.Map<RoomsRoom>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.Rooms.Add(item);
                }

                db.SaveChanges();
            }
        }

        static void AsSteadsDeserializeAndPutToDB(string path, Mapper mapper)
        {
            var formatter = new XmlSerializer(typeof(STEADS));
            var list = new List<SteadsStead>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var objects = formatter.Deserialize(fs) as STEADS;

                if (objects != null)
                {
                    foreach (var obj in objects.STEAD)
                    {
                        var entity = mapper.Map<SteadsStead>(obj);
                        list.Add(entity);
                    }
                }
            }
            using (var db = new MainContext())
            {
                foreach (var item in list)
                {
                    db.Steads.Add(item);
                }

                db.SaveChanges();
            }
        }
    }
}
