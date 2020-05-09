using System;
using System.Xml.Serialization;

namespace XML.SerializeDeserialize
{
    [Serializable]
    [XmlType(TypeName = "root")]
    public class Sample1_1RootModel
    {
        [XmlElement(ElementName = "section")]
        public Sample1_2SectionModel Section { get; set; }
    }
}
