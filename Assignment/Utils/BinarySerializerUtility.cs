///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Utils {

    /// <summary>
    /// A utility class that can be used to serialize any object to a file
    /// </summary>
    public class BinarySerializerUtility {
        /// <summary>
        /// Serializes any serializable object to the specified file.
        /// </summary>
        public static void Serialize(object obj, string filePath) {
            FileStream fileObj = null;

            try {
                fileObj = new FileStream(filePath, FileMode.Create);
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fileObj, obj);
                fileObj.Flush(); // Make sure we wrote everything to file before closing it
            }
            catch { 
                throw;  // Run finally{} and then rethrow the exception
            }
            finally {
                if (fileObj != null)
                    fileObj.Close();

            }
        }

        /// <summary>
        /// Deserializes any (de)serializable object from the given file.
        /// </summary>
        public static T Deserialize<T>(string filepath) {
            FileStream fileObj = null;
            object result = null;

            try {
                if (!File.Exists(filepath)) {
                    throw new FileNotFoundException("File not found. ", filepath);
                }

                fileObj = new FileStream(filepath, FileMode.Open);
                fileObj.Position = 0;
                BinaryFormatter binFormatter = new BinaryFormatter();
                result = binFormatter.Deserialize(fileObj);
            }
            catch{
                throw;  // Run finally{} and then rethrow the exception
            }
            finally {
                if (fileObj != null) {
                    fileObj.Close();
                }
            }

            return (T)result;
        }

    }

}
