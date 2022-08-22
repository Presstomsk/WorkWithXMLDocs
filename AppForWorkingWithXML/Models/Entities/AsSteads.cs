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
        public int Id { get; set; }        
        public string ObjectId { get; set; }        
        public string ObjectGuid { get; set; }        
        public string ChangeId { get; set; }        
        public string Number { get; set; }       
        public string OperTypeId { get; set; }       
        public string PrevId { get; set; }       
        public string NextId { get; set; }       
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
