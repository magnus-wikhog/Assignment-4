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
    /// This class is called Dog. Because it represents dogs...
    /// </summary>
    [Serializable]
    public class Dog : Mammal{
        public double tailLengthCm;


        /// <summary>
        /// Needed for XML serialization.
        /// </summary>
        private Dog() : base(0) {
        }


        /// <summary>
        /// This is a constructor. It can be used to construct an instance of a class.
        /// This particular constructor constructs a Dog.
        /// </summary>
        /// <param name="teethCount"></param>
        /// <param name="tailLengthCm"></param>
        public Dog(int teethCount, double tailLengthCm) : base(teethCount){
            this.tailLengthCm = tailLengthCm;
        }

        /// <summary>
        /// If you want to get the EaterType of a Dog, this is the method for you.
        /// </summary>
        public override EaterType GetEaterType() => EaterType.Omnivore;

        /// <summary>
        /// Dogs must eat, and this method returns the FoodSchedule for a Dog - hence the name
        /// "GetFoodSchedule"...
        /// </summary>
        public override FoodSchedule GetFoodSchedule() => new FoodSchedule(new List<string>(){
            Name+" eats dog food.",
            "He needs to be taken for a walk at least twice a day.",
            "Don't forget doggy bags..."
        });


        /// <summary>
        /// Returns "Dog", since that's the species of this class.
        /// </summary>
        public override string GetSpecies() => "Dog";



        /// <summary>
        /// Returns a string representation of this species special characteristics, including any  
        /// characteristics in it's baseclass.
        /// </summary>
        public override string GetSpecialCharacteristics() {
            return "It's tail is " + tailLengthCm+ " cm long. " + base.GetSpecialCharacteristics();
        }

    }
}
