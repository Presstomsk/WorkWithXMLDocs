using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class Houses
    {
        public HousesHouse[] House { get; set; }
    }
    public class HousesHouse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public long ObjectId { get; set; }
        public Guid ObjectGuid { get; set; }       
        public long ChangeId { get; set; }       
        public string HouseNum { get; set; }      
        public string AddNum1 { get; set; }       
        public string AddNum2 { get; set; }       
        public int? HouseType { get; set; }       
        public int? AddType1 { get; set; }      
        public int? AddType2  { get; set; }       
        public int OperTypeId { get; set; }        
        public long? PrevId { get; set; }       
        public bool PrevIdSpecified { get; set; }        
        public long? NextId { get; set; }        
        public bool NextIdSpecified { get; set; }        
        public DateTime UpdateDate { get; set; }      
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }       
        public HousesHouseIsActual IsActual { get; set; }
        public HousesHouseIsActive IsActive { get; set; }        
    }

    public enum HousesHouseIsActual
    {
        Item0,
        Item1
    }
    public enum HousesHouseIsActive
    {
        Item0,
        Item1
    }
}
