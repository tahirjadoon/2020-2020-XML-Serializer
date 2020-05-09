using System.Collections.Generic;
using System.Xml.Serialization;

namespace XML.SerializeDeserialize
{
    [XmlRoot(ElementName = "connectionStrings")]
    public class Sample2_1RootModel
    {
        [XmlElement(ElementName = "clear")]
        public string Clear { get; set; }

        [XmlElement(ElementName = "add")]
        public List<Sample2_2StringModel> ConnectionStrings { get; set; }
    }
}
