using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppForWorkingWithXML.Models.Entities
{
     public class AsAddrObjAddressObjects
     {
        public AddressObjectsObject[] Object { get; set; } 
     }
    public class AddressObjectsObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public long ObjectId { get; set; }
        public Guid ObjectGuid { get; set; }
        public long ChangeId { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }
        public string Level { get; set; }
        public int OperTypeId { get; set; }
        public long? PrevId { get; set; }
        public bool PrevIdSpecified { get; set; }
        public long? NextId { get; set; }
        public bool NextIdSpecified { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public AddressObjectsObjectIsActual IsActual { get; set; }
        public AddressObjectsObjectIsActive IsActive { get; set; }
    }    
    public enum AddressObjectsObjectIsActual
    {        
        Item0,       
        Item1
    }    
    public enum AddressObjectsObjectIsActive
    {
        Item0,
        Item1
    }
}
