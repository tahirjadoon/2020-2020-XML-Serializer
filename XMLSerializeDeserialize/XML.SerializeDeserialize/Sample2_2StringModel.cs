using System;
using System.Xml.Serialization;

namespace XML.SerializeDeserialize
{
    [XmlRoot(ElementName = "add")]
    public class Sample2_2StringModel
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        private string _connectionString;
        [XmlAttribute(AttributeName = "connectionString")]
        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
                if (!string.IsNullOrWhiteSpace(_connectionString))
                {
                    var connStrings = _connectionString.Split(';');
                    if (connStrings != null && connStrings.Length > 0)
                    {
                        foreach (var item in connStrings)
                        {
                            var items = item.Split('=');
                            if (items != null && items.Length == 2)
                            {
                                switch ((items[0]).Trim().ToUpperInvariant())
                                {
                                    case "DATA SOURCE":
                                        DataSource = items[1].Trim();
                                        break;
                                    case "USER ID":
                                        UserId = items[1].Trim();
                                        break;
                                    case "PASSWORD":
                                        Password = items[1].Trim();
                                        break;
                                    case "VALIDATE CONNECTION":
                                        ValidateConnection = Convert.ToBoolean(items[1].Trim());
                                        break;
                                    case "ENLIST":
                                        Enlist = Convert.ToBoolean(items[1].Trim());
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        [XmlAttribute(AttributeName = "providerName")]
        public string ProviderName { get; set; }

        [XmlIgnore]
        public string DataSource { get; set; }

        [XmlIgnore]
        public string UserId { get; set; }

        [XmlIgnore]
        public string Password { get; set; }

        [XmlIgnore]
        public bool ValidateConnection { get; set; }

        [XmlIgnore]
        public bool Enlist { get; set; }
    }
}
