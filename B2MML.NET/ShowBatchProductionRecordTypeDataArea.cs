﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ShowBatchProductionRecordTypeDataArea {
    
        private TransShowType _showField;
    
        private List<BatchProductionRecordType> _batchProductionRecordField;
    
        /// <remarks/>
        public TransShowType Show {
            get => _showField;
            set => _showField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchProductionRecord")]
        public List<BatchProductionRecordType> BatchProductionRecord {
            get => _batchProductionRecordField;
            set => _batchProductionRecordField = value;
        }
    }
}