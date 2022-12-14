using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class NormativeDocs
    {
        public NormativeDocsNormativeDoc[] NormDoc { get; set; }
    }
    public class NormativeDocsNormativeDoc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }        
        public string Name { get; set; }        
        public DateTime Date { get; set; }        
        public string Number { get; set; }        
        public int Type { get; set; }       
        public int Kind { get; set; }       
        public DateTime UpdateDate { get; set; }       
        public string OrgName { get; set; }       
        public string RegNum { get; set; }       
        public DateTime? RegDate { get; set; }        
        public bool RegDateSpecified { get; set; }        
        public DateTime? AccDate { get; set; }        
        public bool AccDateSpecified { get; set; }       
        public string Comment { get; set; }
        
    }
}
