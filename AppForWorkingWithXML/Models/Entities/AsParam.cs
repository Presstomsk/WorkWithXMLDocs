using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class Params
    {
        public ParamsParam[] Param { get; set; }
    }
    public class ParamsParam
    {
        public long Id { get; set; }
        public long ObjectId { get; set; }       
        public long ChangeId { get; set; }       
        public bool ChangeIdSpecified { get; set; }       
        public long ChangeIdEnd { get; set; }       
        public string TypeId { get; set; }       
        public string Value { get; set; }       
        public DateTime UpdateDate { get; set; }        
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }       
    }
}
