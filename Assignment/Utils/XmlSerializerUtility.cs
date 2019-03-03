///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment.Utils {
    /// <summary>
    /// A class that can serialize/deserialize to/from XML.
    /// </summary>
    public class XMLSerializerUtility {

        /// <summary>
        /// Serializes any serializable object to the specified file.
        /// </summary>
        public static void Serialize<T>(string filePath, T obj) {
            TextWriter writer = null;

            try {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath);
                serializer.Serialize(writer, obj);
                writer.Flush(); // Make sure we wrote everything to file before closing it
            }
            catch {  
                throw; // Run finally{} and then rethrow the exception
            }
            finally {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Deserializes any (de)serializable object from the given file.
        /// </summary>
        public static T Deserialize<T>(string filePath) {
            object result = null;
            TextReader reader = null;

            try {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                result = (T)serializer.Deserialize(reader);
            }
            catch {
                throw;  // Run finally{} and then rethrow the exception
            }
            finally {
                if (reader != null)
                    reader.Close();
            }
            return (T)result;
        }
    }
}
