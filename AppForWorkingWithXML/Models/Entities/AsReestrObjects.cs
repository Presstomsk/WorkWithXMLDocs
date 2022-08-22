using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class ReestrObjects
    {
        public ReestrObjectsObject[] Object { get; set; }
    }
    public class ReestrObjectsObject
    {
        public long ObjectId { get; set; }        
        public DateTime CreateDate { get; set; }        
        public long ChangeId { get; set; }        
        public string LevelId { get; set; }       
        public DateTime UpdateDate { get; set; }       
        public string ObjectGuid { get; set; }       
        public ReestrObjectsObjectIsActive IsActive { get; set; }        
    }
    public enum ReestrObjectsObjectIsActive
    {
        Item0,  
        Item1
    }
}
