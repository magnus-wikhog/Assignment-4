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
    /// This class is called Cat. It represents a cat...
    /// </summary>
    [Serializable]
    public class Cat : Mammal {
        public double clawLengthCm;


        /// <summary>
        /// Needed for XML serialization.
        /// </summary>
        private Cat() : base(0) {
        }

        /// <summary>
        /// A constructor. It constructs cats.
        /// </summary>
        /// <param name="teethCount"></param>
        /// <param name="clawLengthCm"></param>
        public Cat(int teethCount, double clawLengthCm) : base(teethCount) {
            this.clawLengthCm = clawLengthCm;
        }


        /// <summary>
        /// Cats are carnivores, so we return Carnivore as the EaterType.
        /// </summary>
        public override EaterType GetEaterType() => EaterType.Carnivore;


        /// <summary>
        /// Getter for the food schedule. It returns a FoodSchedule.
        /// </summary>
        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" sleeps 23 hours per day.",
            "When he is awake, he eats cat food."
        });

        /// <summary>
        /// This returns "Cat". Beacuse the species of a Cat is "Cat".
        /// </summary>
        public override string GetSpecies() => "Cat";


        /// <summary>
        /// Returns a string representation of this species special characteristics, including any  
        /// characteristics in it's baseclass.
        /// </summary>
        public override string GetSpecialCharacteristics() {
            return "It's claws are " + clawLengthCm + " cm long. " + base.GetSpecialCharacteristics();
        }

    }
}
