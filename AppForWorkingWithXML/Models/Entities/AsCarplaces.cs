using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class Carplaces
    {
        public CarplacesCarplace[] Carplace { get; set; }
    }
    public class CarplacesCarplace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }        
        public long ObjectId { get; set; }        
        public Guid ObjectGuid { get; set; }      
        public long ChangeId { get; set; }       
        public string Number { get; set; }       
        public int OperTypeId { get; set; }       
        public long? PrevId { get; set; }       
        public bool PrevIdSpecified { get; set; }       
        public long? NextId { get; set; }       
        public bool NextIdSpecified { get; set; }       
        public DateTime UpdateDate { get; set; }        
        public DateTime StartDate { get; set; }       
        public DateTime EndDate { get; set; }        
        public CarplacesCarplaceIsActual IsActual { get; set; }        
        public CarplacesCarplaceIsActive IsActive { get; set; }       
    }
    public enum CarplacesCarplaceIsActual
    {
        Item0,
        Item1
    }
    public enum CarplacesCarplaceIsActive
    {
        Item0,
        Item1
    }
}
