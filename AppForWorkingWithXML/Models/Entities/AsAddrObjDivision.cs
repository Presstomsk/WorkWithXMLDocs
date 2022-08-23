using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class AsAddrObjDivisionItems
    {
        public AsAddrObjDivisionItemsItem[] Item { get; set; }
    }
    public class AsAddrObjDivisionItemsItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public long ParentId { get; set; }
        public long ChildId { get; set; }       
        public long ChangeId { get; set; }       
    }
}
