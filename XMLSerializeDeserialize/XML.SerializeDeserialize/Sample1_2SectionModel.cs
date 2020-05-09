using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML.SerializeDeserialize
{
    [Serializable]
    [XmlRoot(ElementName = "section")]
    public class Sample1_2SectionModel
    {
        [XmlElement(ElementName = "connectionString")]
        public List<Sample1_3StringModel> ConnectionString { get; set; }
    }
}
