/* 
 * Magnus Wikhög
 * Assignment 3
 * 2019-02-27
 * 
 */
using Assignment.ListManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Staff {

    /// <summary>
    /// A class representing a member of the staff.
    /// </summary>
    public class Staff {
        private string name;
        private IListManager<string> mQualifications;



        /// <summary>
        /// A constructor that constructs a Staff instance.
        /// </summary>
        public Staff() {
            mQualifications = new ListManager<string>();
        }

        public IListManager<string> Qualifications { get => mQualifications; }



        public string Name {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        override
        public string ToString() {
            return Name + ", " + Qualifications.ToStringList().Aggregate((a, b) => a + ", " + b);
        }

    }
}
