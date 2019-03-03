///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;

namespace Assignment.Animals
{
    /// <summary>
    /// A class. Specifically the Mammal class.
    /// </summary>
    [Serializable]
    public abstract class Mammal : Animal {

        public int teethCount;


        /// <summary>
        /// A constructor. Constructs a Mammal.
        /// </summary>
        /// <param name="teethCount"></param>
        public Mammal(int teethCount) : base() {
            this.teethCount = teethCount;
        }


        /// <summary>
        /// Returns a string representation of this category's special characteristics, including any  
        /// characteristics in it's baseclass.
        /// </summary>
        public override string GetSpecialCharacteristics() {
            return base.GetSpecialCharacteristics() + "It has " + teethCount + " teeth. ";
        }
    }
}
