using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML.SerializeDeserialize
{
    public static class XmlUtility
    {
        /// <summary>
        /// Converts model to xml string
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="dataToSerialize">The model data to be written as xml</param>
        /// <returns>XML string</returns>
        public static string Serialize<T>(T dataToSerialize)
        {
            string xml = "";
            if (dataToSerialize == null)
            {
                throw new Exception("Data to serialize is missing");
            }

            try
            {
                using (var myWriter = new Utf8StringWriterHelper())
                {
                    // use dataToSerialize.GetType() instead of typeof(T). At first glance this seems safe to use T as the type, but if the "dataToSerialize" object 
                    // has been cast to a parent type (ChildClass cast to BaseClass) it will throw an error
                    var myXmlSerializer = new XmlSerializer(dataToSerialize.GetType()); // GetType(T)
                    myXmlSerializer.Serialize(myWriter, dataToSerialize);
                    xml = myWriter.ToString();
                }
            }
            catch
            {
                throw;
            }
            return xml;
        }

        /// <summary>
        /// Converts xml string to model
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="xmlString">The xml string</param>
        /// <returns>Model as T</returns>
        public static T Deserialize<T>(string xmlString)
        {
            if (string.IsNullOrWhiteSpace(xmlString))
            {
                throw new Exception("XML string missing");
            }

            try
            {
                using (var myReader = new StringReader(xmlString))
                {
                    var myXmlSerializer = new XmlSerializer(typeof(T));
                    return (T)myXmlSerializer.Deserialize(myReader);
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Converts xml string to model
        /// </summary>
        /// <typeparam name="T">The model</typeparam>
        /// <param name="filePath">The xml file path</param>
        /// <returns>Model as T</returns>
        public static T DeserializeFilePath<T>(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new Exception("File path is empty!");
            }

            if (!File.Exists(filePath))
            {
                throw new Exception($"Invalid file path: {filePath}");
            }

            try
            {
                var xmlString = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(xmlString))
                {
                    throw new Exception($"File contains no XML: {filePath}");
                }
                return Deserialize<T>(xmlString);
            }
            catch
            {
                throw;
            }
        }
    }
}
