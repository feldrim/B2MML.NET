﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GetWorkflowSpecificationTypeTypeDataArea {
    
        private List<string> _getField;
    
        private List<WorkflowSpecificationTypeType> _workflowSpecificationTypeField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public List<string> Get {
            get => _getField;
            set => _getField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecificationType")]
        public List<WorkflowSpecificationTypeType> WorkflowSpecificationType {
            get => _workflowSpecificationTypeField;
            set => _workflowSpecificationTypeField = value;
        }
    }
}