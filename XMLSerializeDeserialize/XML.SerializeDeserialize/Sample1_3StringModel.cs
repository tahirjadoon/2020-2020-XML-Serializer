using System;
using System.Xml.Serialization;

namespace XML.SerializeDeserialize
{
    [Serializable]
    [XmlRoot(ElementName = "connectionString")]
    public class Sample1_3StringModel
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "userId")]
        public string UserId { get; set; }

        [XmlAttribute(AttributeName = "password")]
        public string Password { get; set; }
    }
}
