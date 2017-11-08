using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace rs12_2011.Util
{
    public static class GenericSerializer
    {
        public static void Serialize<T>(string path, T listToSerialize)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var sw = new StreamWriter(path))
                {
                    serializer.Serialize(sw, listToSerialize);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");               
            }

        }

        public static T Deserialize<T>(string outputPath)
        {
            var ser = new XmlSerializer(typeof(T));
            using (var reader = XmlReader.Create(outputPath))
            {
                return (T)ser.Deserialize(reader);
            }
        }

    }
}
