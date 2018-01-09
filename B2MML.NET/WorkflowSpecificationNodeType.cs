﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class WorkflowSpecificationNodeType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType nodeTypeField;
    
        private WorkflowSpecificationType workflowSpecificationField;
    
        private WorkflowSpecificationPropertyType[] propertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
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
        public IdentifierType NodeType {
            get {
                return nodeTypeField;
            }
            set {
                nodeTypeField = value;
            }
        }
    
        /// <remarks/>
        public WorkflowSpecificationType WorkflowSpecification {
            get {
                return workflowSpecificationField;
            }
            set {
                workflowSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkflowSpecificationPropertyType[] Property {
            get {
                return propertyField;
            }
            set {
                propertyField = value;
            }
        }
    }
}