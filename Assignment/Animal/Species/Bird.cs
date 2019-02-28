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
    /// A class. This particular class is called Bird.
    /// </summary>
    public abstract class Bird : Animal {

        public double wingSpanCm;


        /// <summary>
        /// A bird constructor, constructs a bird.
        /// </summary>
        /// <param name="wingSpanCm"></param>
        public Bird(double wingSpanCm) : base(){
            this.wingSpanCm = wingSpanCm;
        }




        /* 
         * Returns a string representation of this category's special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return base.GetSpecialCharacteristics() + "It's wingspan is " + wingSpanCm + " cm. ";
        }
    }
}
