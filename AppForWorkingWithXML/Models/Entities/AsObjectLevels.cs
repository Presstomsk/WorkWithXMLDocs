using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class ObjectLevels
    {
        public ObjectLevelsObjectLevel[] ObjectLevel { get; set; }
    }
    public class ObjectLevelsObjectLevel
    {
        public int Level { get; set; }        
        public string Name { get; set; }       
        public string ShortName { get; set; }        
        public DateTime UpdateDate { get; set; }       
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }        
        public bool IsActive { get; set; }        
    }
}
