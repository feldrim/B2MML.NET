﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class PhysicalAssetPropertyType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<ValueType> _valueField;
    
        private List<PhysicalAssetPropertyType> _physicalAssetPropertyField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] _physicalAssetCapabilityTestSpecificationIDField;
    
        private List<TestResultType> _testResultField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public List<ValueType> Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetProperty")]
        public List<PhysicalAssetPropertyType> PhysicalAssetProperty {
            get => _physicalAssetPropertyField;
            set => _physicalAssetPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get => _physicalAssetCapabilityTestSpecificationIDField;
            set => _physicalAssetCapabilityTestSpecificationIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestResult")]
        public List<TestResultType> TestResult {
            get => _testResultField;
            set => _testResultField = value;
        }
    }
}