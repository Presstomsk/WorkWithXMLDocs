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
namespace AppForWorkingWithXML.Models.AS.REESTR.OBJECTS
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class REESTR_OBJECTS
    {

        private REESTR_OBJECTSOBJECT[] oBJECTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OBJECT")]
        public REESTR_OBJECTSOBJECT[] OBJECT
        {
            get
            {
                return this.oBJECTField;
            }
            set
            {
                this.oBJECTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class REESTR_OBJECTSOBJECT
    {

        private long oBJECTIDField;

        private System.DateTime cREATEDATEField;

        private long cHANGEIDField;

        private string lEVELIDField;

        private System.DateTime uPDATEDATEField;

        private string oBJECTGUIDField;

        private REESTR_OBJECTSOBJECTISACTIVE iSACTIVEField;

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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime CREATEDATE
        {
            get
            {
                return this.cREATEDATEField;
            }
            set
            {
                this.cREATEDATEField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string LEVELID
        {
            get
            {
                return this.lEVELIDField;
            }
            set
            {
                this.lEVELIDField = value;
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
        public REESTR_OBJECTSOBJECTISACTIVE ISACTIVE
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
    public enum REESTR_OBJECTSOBJECTISACTIVE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }
}
