using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace CthulhuCharacterSheet.Utils.Xml
{
    // Based on an implementation Michael showed me
    // He said he found it online somewhere
    public class DataContractSerializationUtil : IXmlSerializationUtil
    {
        public T Deserialize<T>(string xml)
        {
            var dcs = new DataContractSerializer(typeof(T));

            using (var strReader = new StringReader(xml))
            {
                using (var xmlReader = XmlReader.Create(strReader))
                {
                    return (T)dcs.ReadObject(xmlReader);
                }
            }
        }

        public string Serialize<T>(T graph)
        {
            var sb = new StringBuilder();
            var dcs = new DataContractSerializer(graph.GetType());

            //Serialize the settings
            using (var writer = XmlWriter.Create(sb))
            {
                dcs.WriteObject(writer, graph);
                writer.Flush();
            }

            return sb.ToString();
        }
    }

    public interface IXmlSerializationUtil
    {
        T Deserialize<T>(string xml);
        string Serialize<T>(T graph);
    }
}