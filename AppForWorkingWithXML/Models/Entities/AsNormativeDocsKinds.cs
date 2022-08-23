using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class NormativeDocsKinds
    {
        public NormativeDocsKind[] NDocKind { get; set; }
    }
    public class NormativeDocsKind
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }       
        public string Name { get; set; }        
    }
}
