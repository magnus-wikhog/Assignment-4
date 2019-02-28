/* 
 * Magnus Wikhög
 * Assignment 3
 * 2019-02-27
 * 
 */
using System.Collections.Generic;

namespace Assignment.Animals
{
    /// <summary>
    /// This is a class. It's called Swan. It is used to represent swans, which are a
    /// type of birds.
    /// </summary>
    public class Swan : Bird{
        public string color;

        /// <summary>
        /// A constructor. Use it to construct a swan.
        /// </summary>
        /// <param name="wingSpanCm"></param>
        /// <param name="color"></param>
        public Swan(double wingSpanCm, string color) : base(wingSpanCm) {
            this.color = color;
        }

        /// <summary>
        /// Returns the EaterType of this class.
        /// </summary>
        public override EaterType GetEaterType() => EaterType.Herbivore;

        /// <summary>
        /// Returns the FoodSchedule of this class.
        /// </summary>
        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" likes to eat seaweeds.",
            "Will also eat bread crumbs from time to time."
        });


        /// <summary>
        /// Returns "Swan", since this is the Swan class.
        /// </summary>
        public override string GetSpecies() => "Swan";



        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It is a " + color + " swan. " + base.GetSpecialCharacteristics();
        }

    }
}
