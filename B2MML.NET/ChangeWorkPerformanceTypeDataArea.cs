﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeWorkPerformanceTypeDataArea {
    
        private TransChangeType _changeField;
    
        private WorkPerformanceType[] _workPerformanceField;
    
        /// <remarks/>
        public TransChangeType Change {
            get => _changeField;
            set => _changeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkPerformance")]
        public WorkPerformanceType[] WorkPerformance {
            get => _workPerformanceField;
            set => _workPerformanceField = value;
        }
    }
}