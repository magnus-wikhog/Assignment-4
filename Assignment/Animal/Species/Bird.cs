///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Assignment.Animals
{
    /// <summary>
    /// A class. This particular class is called Bird.
    /// </summary>
    [Serializable]
    public abstract class Bird : Animal {

        public double wingSpanCm;


        /// <summary>
        /// A bird constructor, constructs a bird.
        /// </summary>
        /// <param name="wingSpanCm"></param>
        public Bird(double wingSpanCm) : base(){
            this.wingSpanCm = wingSpanCm;
        }




        /// <summary>
        /// Returns a string representation of this category's special characteristics, including any  
        /// characteristics in it's baseclass.
        /// </summary>
        public override string GetSpecialCharacteristics() {
            return base.GetSpecialCharacteristics() + "It's wingspan is " + wingSpanCm + " cm. ";
        }
    }
}
