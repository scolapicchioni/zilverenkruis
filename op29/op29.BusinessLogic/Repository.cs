using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace op29.BusinessLogic {
    public class Repository {
        public void WriteOnFile(string message) {
            string path = @"C:\temp\simo01.txt";

            File.AppendAllText(path, message);

        }

        public void SerializeBinary(Potato potato) {
            FileStream fs = new FileStream(@"C:\temp\BinaryPotato.dat", FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try {
                formatter.Serialize(fs, potato);
            } catch (SerializationException e) {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            } finally {
                fs.Close();
            }
        }

        public Potato DeserializeBinary() {
            FileStream fs = new FileStream(@"C:\temp\BinaryPotato.dat", FileMode.Open);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try {
                Potato result = (Potato)formatter.Deserialize(fs);
                return result;
            } catch (SerializationException e) {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            } finally {
                fs.Close();
            }
        }

        public void SerializeXML(Potato potato) {
            XmlSerializer serializer =
            new XmlSerializer(typeof(Potato));
            TextWriter writer = new StreamWriter(@"C:\temp\XMLPotato.xml");
            serializer.Serialize(writer, potato);
            writer.Close();
        }

        public Potato DeserializeXML() {
            XmlSerializer serializer = new XmlSerializer(typeof(Potato));
            FileStream fs = new FileStream(@"C:\temp\XMLPotato.xml", FileMode.Open);
            Potato po;
            /* Use the Deserialize method to restore the object's state with
            data from the XML document. */
            po = (Potato)serializer.Deserialize(fs);
            return po;
        }

        public void SerializeJSON(Potato potato) {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"C:\temp\jsonPotato.json"))
            using (JsonWriter writer = new JsonTextWriter(sw)) {
                serializer.Serialize(writer, potato);
            }
        }

        public Potato DeserializeJSON() {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamReader sr = new StreamReader(@"C:\temp\jsonPotato.json"))
            using (JsonReader reader = new JsonTextReader(sr)) {
                return serializer.Deserialize<Potato>(reader);
            }
        }
    }
}
