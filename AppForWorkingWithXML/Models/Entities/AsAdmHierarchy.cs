using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class AsAdmHierarchyItem
    {
        public AsAdmHierarchyItemsItem[] ITEM { get; set; }
    }
    public class AsAdmHierarchyItemsItem
    {
        public long Id { get; set; }        
        public long ObjectId { get; set; }        
        public long? ParentObjId { get; set; }        
        public bool ParentObjIdSpecified { get; set; }        
        public long ChangeId { get; set; }        
        public string RegionCode { get; set; }        
        public string AreaCode { get; set; }        
        public string CityCode { get; set; }        
        public string PlaceCode { get; set; } 
        public string PlanCode { get; set; } 
        public string StreetCode { get; set; }       
        public long? PrevId { get; set; }        
        public bool revIdSpecified { get; set; }        
        public long? NextId  { get; set; }        
        public bool NextIdSpecified { get; set; }        
        public DateTime UpdateDate { get; set; }       
        public DateTime StartDate { get; set; }       
        public DateTime EndDate { get; set; }       
        public ItemsItemIsActive IsActive { get; set; }        
        public string Path { get; set; }
        
    }
    public enum ItemsItemIsActive
    {
        Item0,
        Item1
    }
}
