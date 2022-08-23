using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class NormativeDocsTypes
    {
        public NormativeDocsType[] NDocType { get; set; }
    }
    public class NormativeDocsType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }        
        public string Name { get; set; }       
        public DateTime StartDate { get; set; }       
        public DateTime EndDate { get; set; }
    }
}
