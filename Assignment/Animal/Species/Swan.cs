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
    /// This is a class. It's called Swan. It is used to represent swans, which are a
    /// type of birds.
    /// </summary>
    [Serializable]
    public class Swan : Bird{
        public string color;

        /// <summary>
        /// Needed for XML serialization.
        /// </summary>
        private Swan() : base(0) {
        }


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



        /// <summary>
        /// Returns a string representation of this species special characteristics, including any  
        /// characteristics in it's baseclass.
        /// </summary>
        public override string GetSpecialCharacteristics() {
            return "It is a " + color + " swan. " + base.GetSpecialCharacteristics();
        }

    }
}
