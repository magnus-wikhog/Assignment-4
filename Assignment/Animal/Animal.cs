using System;
using System.Xml.Serialization;
///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
namespace Assignment.Animals
{

    /// <summary>
    /// This is the abstract base class for all animal species, and contains common
    /// properties for all species.
    /// </summary>
    [XmlInclude(typeof(Cat))]
    [XmlInclude(typeof(Dog))]
    [XmlInclude(typeof(Crow))]
    [XmlInclude(typeof(Swan))]
    [Serializable]
    public abstract class Animal : IAnimal{


        /// <summary>
        /// Abstract interface methods that need to be implemented by subclasses
        /// </summary>
        public abstract EaterType GetEaterType();
        public abstract FoodSchedule GetFoodSchedule();
        public abstract string GetSpecies();


        /// <summary>
        ///  Public properties common to all animals
        /// </summary>
        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int age;


        protected string id;
        protected string name;
        protected string gender;


        /// <summary>
        /// The constructor for the Animal class.
        /// </summary>
        public Animal() { }



         /// <summary>
         /// This method will be overriden by subclasses and used to get a string representation
         /// of the special characteristics for an animal category and an animal species.
         /// </summary>
         /// <returns></returns>
        public virtual string GetSpecialCharacteristics() {
            return "";
        }

    }
}
