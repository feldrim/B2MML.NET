﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SyncPhysicalAssetInformationTypeDataArea {
    
        private TransActionCriteriaType[] syncField;
    
        private PhysicalAssetInformationType[] physicalAssetInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Sync {
            get {
                return syncField;
            }
            set {
                syncField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetInformation")]
        public PhysicalAssetInformationType[] PhysicalAssetInformation {
            get {
                return physicalAssetInformationField;
            }
            set {
                physicalAssetInformationField = value;
            }
        }
    }
}