using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class AsMunHierarchyItems
    {
        public AsMunHierarchyItemsItem[] Item { get; set; }
    }
    public class AsMunHierarchyItemsItem
    {
        public long Id { get; set; }       
        public long ObjectId { get; set; }        
        public long? ParentObjId { get; set; }        
        public bool ParentObjIdSpecified { get; set; }        
        public long ChangeId { get; set; }        
        public string Oktmo { get; set; }       
        public long? PrevId { get; set; }       
        public bool PrevIdSpecified { get; set; }        
        public long? NextId { get; set; }       
        public bool NextIdSpecified { get; set; }
        public DateTime UpdateDate { get; set; }        
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }        
        public AsMunHierarchyItemsIsActive IsActive { get; set; }        
        public string Path { get; set; }       
    }
    public enum AsMunHierarchyItemsIsActive
    {
        Item0,
        Item1
    }
}
