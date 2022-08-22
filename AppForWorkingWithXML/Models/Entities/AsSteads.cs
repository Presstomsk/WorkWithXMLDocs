using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class Steads
    {
        public SteadsStead[] Stead { get; set; }
    }
    public class SteadsStead
    {
        public long Id { get; set; }        
        public long ObjectId { get; set; }        
        public Guid ObjectGuid { get; set; }        
        public long ChangeId { get; set; }        
        public string Number { get; set; }       
        public int OperTypeId { get; set; }       
        public long? PrevId { get; set; }       
        public long? NextId { get; set; }       
        public DateTime UpdateDate { get; set; }        
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }        
        public SteadsSteadIsActual IsActual { get; set; }        
        public SteadsSteadIsActive IsActive { get; set; }
        
    }
    public enum SteadsSteadIsActual
    {

        Item0,
        Item1
    }
    public enum SteadsSteadIsActive
    {       
        Item0,
        Item1
    }
}
