﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ProcessWorkAlertDefinitionTypeDataArea {
    
        private TransProcessType _processField;
    
        private List<WorkAlertDefinitionType> _workAlertDefinitionField;
    
        /// <remarks/>
        public TransProcessType Process {
            get => _processField;
            set => _processField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkAlertDefinition")]
        public List<WorkAlertDefinitionType> WorkAlertDefinition {
            get => _workAlertDefinitionField;
            set => _workAlertDefinitionField = value;
        }
    }
}