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
namespace AppForWorkingWithXML.Models.AS.ADDR.OBJ.DIVISION
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ITEMS
    {

        private ITEMSITEM[] iTEMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ITEM")]
        public ITEMSITEM[] ITEM
        {
            get
            {
                return this.iTEMField;
            }
            set
            {
                this.iTEMField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ITEMSITEM
    {

        private long idField;

        private long pARENTIDField;

        private long cHILDIDField;

        private long cHANGEIDField;

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
        public long PARENTID
        {
            get
            {
                return this.pARENTIDField;
            }
            set
            {
                this.pARENTIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long CHILDID
        {
            get
            {
                return this.cHILDIDField;
            }
            set
            {
                this.cHILDIDField = value;
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
    }
}
