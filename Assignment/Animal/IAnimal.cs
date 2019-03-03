///<summary>
/// Namn:       Magnus Wikhög
/// Projekt:    _projekt_namn__
/// Inlämnad:   _inlämnad_datum_
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Animals{

    /// <summary>
    /// Different types of animals have different EaterTypes.
    /// </summary>
    public enum EaterType { Herbivore, Carnivore, Omnivore };


    /// <summary>
    /// An interface for animal types.
    /// </summary>
    interface IAnimal{
        string ID { get; }
        string Name { get; set; }
        string Gender { get; set; }

        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();
    }

}
