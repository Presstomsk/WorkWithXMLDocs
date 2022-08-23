﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class RoomTypes
    {
        public RoomTypesRoomType[] RoomType { get; set; }
    }
    public class RoomTypesRoomType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }       
        public string Name { get; set; }        
        public string ShortName { get; set; }       
        public string Desc { get; set; }       
        public DateTime UpdateDate { get; set; }       
        public DateTime StartDate { get; set; }        
        public DateTime EndDate { get; set; }        
        public bool IsActive { get; set; }        
    }
}
