using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class Rooms
    {
        public RoomsRoom[] Room { get; set; }
    }
    public class RoomsRoom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }        
        public long ObjectId { get; set; }       
        public Guid ObjectGuid { get; set; }       
        public long ChangeId { get; set; }        
        public string Number { get; set; }        
        public int RoomType { get; set; }       
        public int OperTypeId { get; set; }       
        public long? PrevId { get; set; }       
        public bool PrevIdSpecified { get; set; }        
        public long? NextId { get; set; }      
        public bool NextIdSpecified { get; set; }        
        public DateTime UpdateDate { get; set; }       
        public DateTime StartDate { get; set; }      
        public DateTime EndDate { get; set; }        
        public RoomsRoomIsActual IsActual { get; set; }        
        public RoomsRoomIsActive IsActive { get; set; }        
    }
    public enum RoomsRoomIsActual
    {
        Item0,
        Item1
    }
    
    public enum RoomsRoomIsActive
    {
        Item0,
        Item1
    }
}
