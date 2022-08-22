using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class NormativeDocsKinds
    {
        public NormativeDocsKind[] NDocKind { get; set; }
    }
    public class NormativeDocsKind
    {
        public int Id { get; set; }       
        public string Name { get; set; }        
    }
}
