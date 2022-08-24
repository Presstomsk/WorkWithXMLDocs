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
            XmlSerializer formatter = new XmlSerializer(typeof(STEADS));
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            var mapper = new Mapper(config);
            List<SteadsStead> list = new List<SteadsStead>();

            using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\Рабочая\Docs\99\AS_STEADS_20220808_59873b8f-d237-42b9-9cbe-592d9de8e2df.XML", FileMode.OpenOrCreate))
            {
                STEADS objects = formatter.Deserialize(fs) as STEADS;

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
                db.Database.Migrate();

                foreach (var item in list) 
                {
                    db.Steads.Add(item);
                }

                db.SaveChanges();     
            }
            
                         
            
        }
    }
}
