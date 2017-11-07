using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace rs12_2011.Util
{
    public static class GenericSerializer
    {
        public static void Serialize<T>(string path, List<T> listToSerialize)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var sw = new StreamWriter(path))
                {
                    serializer.Serialize(sw, listToSerialize);
                }
            }
            catch
            {
            }

        }
        private static List<T> Deserialize<T>(string outputPath)
        {
            var ser = new XmlSerializer(typeof(T));
            using (var reader = XmlReader.Create(outputPath))
            {
                return (List<T>)ser.Deserialize(reader);
            }
        }

    }
}
