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
            XmlSerializer formatter = new XmlSerializer(typeof(ADDRESSOBJECTS));
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            var mapper = new Mapper(config);
            List<AddressObjectsObject> list = new List<AddressObjectsObject>();

            using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_ADDR_OBJ_20220808_e44fba35-1045-48b4-bba0-ddb28e5126fa.XML", FileMode.OpenOrCreate))
            {
                ADDRESSOBJECTS objects = formatter.Deserialize(fs) as ADDRESSOBJECTS;

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
                db.Database.Migrate();

                foreach (var item in list) 
                {
                    db.AddressObjects.Add(item);
                }

                db.SaveChanges();     
            }
            
                         
            
        }
    }
}
