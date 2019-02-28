/* 
 * Magnus Wikhög
 * Assignment 3
 * 2019-02-27
 * 
 */
using System;
using System.Collections.Generic;
using Assignment.Animals;
using Assignment.ListManager;

namespace Assignment.Animals{

    /* 
     * This class manages our animals. It lets us add animals and retrieve them.
     */
    public class AnimalManager : ListManager<Animal> {

        public void AddAnimal(Animal animal) {
            animal.ID = string.Format("{0:P}-{1:000}", animal.GetSpecies(), Count);
            Add(animal);
        }

    }


    /*
     * Compares animal ages (ascending)
     */
    public class AgeComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.age - y.age;
        }
    }


    /*
     * Compares animal names (ascending)
     */
    public class NameComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Name.CompareTo(y.Name);
        }
    }


    /*
     * Compares animal ID's (ascending)
     */
    public class IdComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.ID.CompareTo(y.ID);
        }
    }


    /*
     * Compares animal genders (ascending)
     */
    public class GenderComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Gender.CompareTo(y.Gender);
        }
    }


    /*
     * Compares animal species (ascending)
     */
    public class SpeciesComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.GetSpecies().CompareTo(y.GetSpecies());
        }
    }
    


    /*
     * Compares animal characteristics (ascending)
     */
    public class SpecialCharacteristicsComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.GetSpecialCharacteristics().CompareTo(y.GetSpecialCharacteristics());
        }
    }

}
