using System;
using System.Collections.Generic;
using System.Text;

namespace AppForWorkingWithXML.Models.Entities
{
    public class AsChangeHistoryItems
    {
        public AsChangeHistoryItemsItem[] Item { get; set; }
    }
    public class AsChangeHistoryItemsItem
    {
        public long ChangeId { get; set; }
        public long ObjectId { get; set; }
        public string AdrObjectId { get; set; }
        public string OperTypeId { get; set; }       
        public long NDocId { get; set; }       
        public bool NDocIdSpecified { get; set; }      
        public DateTime ChangeDate { get; set; }      
    }
}
