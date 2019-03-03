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
    /// A class representing Crows, which are Birds.
    /// </summary>
    [Serializable]
    public class Crow : Bird{
        public double weightKg;


        /// <summary>
        /// Needed for XML serialization.
        /// </summary>
        private Crow() : base(0) {
        }


        /// <summary>
        /// A constructor. It constructs a Crow.
        /// </summary>
        /// <param name="wingSpanCm"></param>
        /// <param name="weightKg"></param>
        public Crow(double wingSpanCm, double weightKg) : base(wingSpanCm) {
            this.weightKg = weightKg;
        }

        /// <summary>
        /// Returns the EaterType for this class.
        /// </summary>
        /// <returns></returns>
        public override EaterType GetEaterType() => EaterType.Omnivore;

        /// <summary>
        /// Returns the FoodSchedule.
        /// </summary>
        /// <returns></returns>
        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" will eat all sorts of things.",
            "Crows will usually find food on their own."
        });

        /// <summary>
        /// Returns the species of this class as a string.
        /// </summary>
        /// <returns></returns>
        public override string GetSpecies() => "Crow";



        /// <summary>
        /// Returns a string representation of this species special characteristics, including any  
        /// characteristics in it's baseclass.
        /// </summary>
        public override string GetSpecialCharacteristics() {
            return "It weighs " + weightKg + " kg. " + base.GetSpecialCharacteristics();
        }

    }
}
