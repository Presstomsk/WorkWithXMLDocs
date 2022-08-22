using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class AsAddrObjDivisionItems
    {
        public AsAddrObjDivisionItemsItem[] Item { get; set; }
    }
    public class AsAddrObjDivisionItemsItem
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public long ChildId { get; set; }       
        public long ChangeId { get; set; }       
    }
}
