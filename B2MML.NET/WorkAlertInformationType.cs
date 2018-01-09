﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkAlertInformation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class WorkAlertInformationType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PublishedDateType _publishedDateField;
    
        private WorkAlertDefinitionType[] _workAlertDefinitionField;
    
        private WorkAlertType[] _workAlertField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", IsNullable=true)]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PublishedDateType PublishedDate {
            get => _publishedDateField;
            set => _publishedDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkAlertDefinition", IsNullable=true)]
        public WorkAlertDefinitionType[] WorkAlertDefinition {
            get => _workAlertDefinitionField;
            set => _workAlertDefinitionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkAlert", IsNullable=true)]
        public WorkAlertType[] WorkAlert {
            get => _workAlertField;
            set => _workAlertField = value;
        }
    }
}