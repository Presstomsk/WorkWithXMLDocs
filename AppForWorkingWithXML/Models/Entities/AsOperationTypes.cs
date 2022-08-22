using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class OperationTypes
    {
        public OperationTypesOperationType[] OperationType { get; set; }
    }
    public class OperationTypesOperationType
    {
        public int Id { get; set; }        
        public string Name { get; set; }        
        public string ShortName { get; set; }       
        public string Desc { get; set; }        
        public DateTime UpdateDate { get; set; }       
        public DateTime StartDate { get; set; }       
        public DateTime EndDate { get; set; }       
        public bool IsActive { get; set; }
        
    }
}
