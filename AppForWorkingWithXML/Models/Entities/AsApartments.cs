using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class Apartments
    {
        public ApartmentsApartment[] Apartment { get; set; }
    }
    public class ApartmentsApartment
    {
        public long Id { get; set; }       
        public long ObjectId { get; set; }      
        public Guid ObjectGuid { get; set; }       
        public long ChangeId { get; set; }       
        public string Number { get; set; }        
        public int ApartType { get; set; }       
        public long OperTypeId { get; set; }        
        public long? PrevId { get; set; }       
        public bool PrevIdSpecified { get; set; }       
        public long? NextId { get; set; }        
        public bool NextIdSpecified { get; set; }        
        public DateTime UpdateDate { get; set; }        
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }       
        public ApartmentsApartmentIsActual IsActual { get; set; } 
        public ApartmentsApartmentIsActive IsActive { get; set; }
    
    }
    public enum ApartmentsApartmentIsActual
    {
        Item0,
        Item1
    }  
  
    public enum ApartmentsApartmentIsActive

    {
        Item0,
        Item1
    }
}
