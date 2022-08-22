using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class ParamTypes
    {
        public ParamTypesParamType[] ParamType { get; set; }
    }
    public class ParamTypesParamType
    {
        public int Id { get; set; }        
        public string Name { get; set; }        
        public string Code { get; set; }        
        public string Desc { get; set; }       
        public DateTime UpdateDate { get; set; }        
        public DateTime StartDate { get; set; }       
        public DateTime EndDate { get; set; }        
        public bool IsActive { get; set; }       
    }
}
