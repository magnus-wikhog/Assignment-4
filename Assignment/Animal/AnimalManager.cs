///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;
using Assignment.Animals;
using Assignment.ListManager;

namespace Assignment.Animals{

    /// <summary>
    /// This class manages our animals. It lets us add animals and retrieve them.
    /// </summary>
    public class AnimalManager : ListManager<Animal> {

        public void AddAnimal(Animal animal) {
            animal.ID = string.Format("{0:P}-{1:000}", animal.GetSpecies(), Count);
            Add(animal);
        }

    }


    /// <summary>
    /// Compares animal ages (ascending)
    /// </summary>
    public class AgeComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.age - y.age;
        }
    }


    /// <summary>
    /// Compares animal names (ascending)
    /// </summary>
    public class NameComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Name.CompareTo(y.Name);
        }
    }


    /// <summary>
    /// Compares animal ID's (ascending)
    /// </summary>
    public class IdComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.ID.CompareTo(y.ID);
        }
    }


    /// <summary>
    /// Compares animal genders (ascending)
    /// </summary>
    public class GenderComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.Gender.CompareTo(y.Gender);
        }
    }


    /// <summary>
    /// Compares animal species (ascending)
    /// </summary>
    public class SpeciesComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.GetSpecies().CompareTo(y.GetSpecies());
        }
    }



    /// <summary>
    /// Compares animal characteristics (ascending)
    /// </summary>
    public class SpecialCharacteristicsComparer : IComparer<Animal> {
        public int Compare(Animal x, Animal y) {
            return x.GetSpecialCharacteristics().CompareTo(y.GetSpecialCharacteristics());
        }
    }

}
