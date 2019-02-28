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
    /// This class is called Cat. It represents a cat...
    /// </summary>
    public class Cat : Mammal {
        public double clawLengthCm;

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


        /* 
         * Returns a string representation of this species special characteristics, including any 
         * characteristics in it's baseclass.
         */
        public override string GetSpecialCharacteristics() {
            return "It's claws are " + clawLengthCm + " cm long. " + base.GetSpecialCharacteristics();
        }

    }
}
