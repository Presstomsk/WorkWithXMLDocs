﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
// 


/// <remarks/>
namespace AppForWorkingWithXML.Models.Dto
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Rooms
    {

        private RoomsRoom[] rOOMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ROOM")]
        public RoomsRoom[] ROOM
        {
            get
            {
                return this.rOOMField;
            }
            set
            {
                this.rOOMField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RoomsRoom
    {

        private long idField;

        private long oBJECTIDField;

        private string oBJECTGUIDField;

        private long cHANGEIDField;

        private string nUMBERField;

        private string rOOMTYPEField;

        private string oPERTYPEIDField;

        private long pREVIDField;

        private bool pREVIDFieldSpecified;

        private long nEXTIDField;

        private bool nEXTIDFieldSpecified;

        private System.DateTime uPDATEDATEField;

        private System.DateTime sTARTDATEField;

        private System.DateTime eNDDATEField;

        private ROOMSROOMISACTUAL iSACTUALField;

        private ROOMSROOMISACTIVE iSACTIVEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long OBJECTID
        {
            get
            {
                return this.oBJECTIDField;
            }
            set
            {
                this.oBJECTIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OBJECTGUID
        {
            get
            {
                return this.oBJECTGUIDField;
            }
            set
            {
                this.oBJECTGUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long CHANGEID
        {
            get
            {
                return this.cHANGEIDField;
            }
            set
            {
                this.cHANGEIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NUMBER
        {
            get
            {
                return this.nUMBERField;
            }
            set
            {
                this.nUMBERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ROOMTYPE
        {
            get
            {
                return this.rOOMTYPEField;
            }
            set
            {
                this.rOOMTYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string OPERTYPEID
        {
            get
            {
                return this.oPERTYPEIDField;
            }
            set
            {
                this.oPERTYPEIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long PREVID
        {
            get
            {
                return this.pREVIDField;
            }
            set
            {
                this.pREVIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PREVIDSpecified
        {
            get
            {
                return this.pREVIDFieldSpecified;
            }
            set
            {
                this.pREVIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long NEXTID
        {
            get
            {
                return this.nEXTIDField;
            }
            set
            {
                this.nEXTIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NEXTIDSpecified
        {
            get
            {
                return this.nEXTIDFieldSpecified;
            }
            set
            {
                this.nEXTIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime UPDATEDATE
        {
            get
            {
                return this.uPDATEDATEField;
            }
            set
            {
                this.uPDATEDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime STARTDATE
        {
            get
            {
                return this.sTARTDATEField;
            }
            set
            {
                this.sTARTDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ENDDATE
        {
            get
            {
                return this.eNDDATEField;
            }
            set
            {
                this.eNDDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ROOMSROOMISACTUAL ISACTUAL
        {
            get
            {
                return this.iSACTUALField;
            }
            set
            {
                this.iSACTUALField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ROOMSROOMISACTIVE ISACTIVE
        {
            get
            {
                return this.iSACTIVEField;
            }
            set
            {
                this.iSACTIVEField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ROOMSROOMISACTUAL
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ROOMSROOMISACTIVE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
}