/* 
 * Magnus Wikhög
 * Assignment 3
 * 2019-02-27
 * 
 */
using System;
using System.Collections.Generic;

namespace Assignment.Animals
{
    /// <summary>
    /// A class. Specifically the Mammal class.
    /// </summary>
    public abstract class Mammal : Animal {

        public int teethCount;


        /// <summary>
        /// A constructor. Constructs a Mammal.
        /// </summary>
        /// <param name="teethCount"></param>
        public Mammal(int teethCount) : base() {
            this.teethCount = teethCount;
        }



        /* 
         * Returns a string representation of this category's special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return base.GetSpecialCharacteristics() + "It has " + teethCount + " teeth. ";
        }
    }
}
