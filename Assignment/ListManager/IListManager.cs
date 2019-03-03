///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ListManager {

    /// <summary>Genereic interface for a class that manages a list of objects of type T.</summary>
    /// <typeparam name="T">The type of objects handled by the list manager.</typeparam>
    public interface IListManager<T> {

        /// <summary>
        /// Serializes the list manager to the given binary file.
        /// </summary>
        void BinarySerialize(string filename);

        /// <summary>
        /// Deserializes a list manager from the given binary file.
        /// </summary>
        void BinaryDeSerialize(string filename);

        /// <summary>
        /// Serializes the list manager to the given XML file.
        /// </summary>
        void XMLSerialize(string filename);

        /// <summary>
        /// Deserializes a list manager from the given XML file.
        /// </summary>
        void XMLDeSerialize(string filename);


        /// <summary>
        /// Returns the number of items in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds an object to the list.
        /// </summary>
        /// <param name="aType">The object to add</param>
        /// <returns></returns>
        bool Add(T aType);

        /// <summary>
        /// Replaces the item at anIndex with aType.
        /// </summary>
        /// <param name="aType">The object to put in the list.</param>
        /// <param name="anIndex">The index to put the object at.</param>
        /// <returns></returns>
        bool ChangeAt(T aType, int anIndex);

        /// <summary>
        /// Checks the validity of the given index.
        /// </summary>
        /// <param name="index">The index to checkl</param>
        /// <returns>True if within bounds, false otherwise.</returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Removes all items from the list.
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Removes the item at the given index.
        /// </summary>
        /// <param name="anIndex">The index of the item to be removed.</param>
        /// <returns>True on success, false on failure.</returns>
        bool DeleteAt(int anIndex);

        /// <summary>
        /// Returns the object at the given index.
        /// </summary>
        /// <param name="anIndex">The index.</param>
        /// <returns>The object at index, or null if index is invalid.</returns>
        T GetAt(int anIndex);

        /// <summary>
        /// Returns a string representation of all objects in the list.
        /// </summary>
        /// <returns>An array of string representations of all items in the list.</returns>
        string[] ToStringArray();

        /// <summary>
        /// Returns a string representation of all objects in the list.
        /// </summary>
        /// <returns>A List of string representations of all items in the list.</returns>
        List<string> ToStringList();
    }
}
