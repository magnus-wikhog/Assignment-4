/* 
 * Magnus Wikhög
 * Assignment 3
 * 2019-02-27
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ListManager {
    /// <summary>
    /// A class that manages a list of objects.
    /// </summary>
    public class ListManager<T> : IListManager<T> {

        private List<T> m_list;


        /// <summary>
        /// The constructor for this class.
        /// </summary>
        public ListManager() {
            m_list = new List<T>();
        }


        public int Count => m_list.Count;

        /// <summary>
        /// Adds the supplied object to the list.
        /// </summary>
        /// <param name="aType">The object to add</param>
        /// <returns>Always returns True</returns>
        public bool Add(T aType) {
            m_list.Add(aType);
            return true;
        }


        /// <summary>
        /// Changes the object at the given index to the given object.
        /// </summary>
        /// <param name="aType">The object to put at the given index</param>
        /// <param name="anIndex">The index to change the object at</param>
        /// <returns></returns>
        public bool ChangeAt(T aType, int anIndex) {
            if (!CheckIndex(anIndex)) return false;
            m_list[anIndex] = aType;
            return true;
        }

        /// <summary>
        /// Returns true if the given index is valid, false otherwise.
        /// </summary>
        public bool CheckIndex(int index) => index > -1 && index < m_list.Count;


        /// <summary>
        /// Clears the list.
        /// </summary>
        public void DeleteAll() => m_list.Clear();        


        /// <summary>
        /// Removes the object at the given index.
        /// </summary>
        /// <param name="anIndex">The index of the object to remove.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public bool DeleteAt(int anIndex) {
            if (!CheckIndex(anIndex)) return false;
            m_list.RemoveAt(anIndex);
            return true;
        }


        /// <summary>
        /// Returns the object at the given index, or the default value for the type of objects in the list.
        /// </summary>
        /// <param name="anIndex">The index of the object to return</param>
        /// <returns>An object or a default value</returns>
        public T GetAt(int anIndex) => m_list.ElementAtOrDefault(anIndex);

        /// <summary>
        /// Returns a string array of the objects in the list, i.e. calls ToString() on each object in the list
        /// and returns the resulting strings in an array.
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray() => m_list.ConvertAll<string>((T item) => item.ToString()).ToArray<string>();        


        /// <summary>
        /// Returns a list of string representations of the objects in the list, i.e. calls ToString() on each object
        /// in the list and returns the resulting strings in a list.
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList() => m_list.ConvertAll<string>((T item) => item.ToString());


        /// <summary>
        /// Sorts the list using the supplied IComparer
        /// </summary>
        public void Sort(IComparer<T> comparer) {
            m_list.Sort(comparer);
        }

    }
}
