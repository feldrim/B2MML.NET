﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentSegmentSpecificationType {
    
        private EquipmentClassIDType equipmentClassIDField;
    
        private EquipmentIDType equipmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private CodeType equipmentUseField;
    
        private QuantityValueType[] quantityField;
    
        private EquipmentSegmentSpecificationPropertyType[] equipmentSegmentSpecificationPropertyField;
    
        /// <remarks/>
        public EquipmentClassIDType EquipmentClassID {
            get {
                return equipmentClassIDField;
            }
            set {
                equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public CodeType EquipmentUse {
            get {
                return equipmentUseField;
            }
            set {
                equipmentUseField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return quantityField;
            }
            set {
                quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSegmentSpecificationProperty")]
        public EquipmentSegmentSpecificationPropertyType[] EquipmentSegmentSpecificationProperty {
            get {
                return equipmentSegmentSpecificationPropertyField;
            }
            set {
                equipmentSegmentSpecificationPropertyField = value;
            }
        }
    }
}