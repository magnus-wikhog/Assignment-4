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

namespace Assignment.Animals {
    class AnimalFactory {

        /// <summary>
        /// Factory method which creates a concrete animal based on the given parameters.
        /// </summary>
        /// <param name="speciesName">The name of the species</param>
        /// <param name="attributes">Attributes specific to the species</param>
        /// <returns></returns>
        public static Animal CreateAnimal(string speciesName, Dictionary<string, Object> attributes) {
            switch (speciesName) {
                case "Cat": return new Cat((int)attributes["mammalTeethCount"], (double)attributes["catClawLength"]);
                case "Dog": return new Dog((int)attributes["mammalTeethCount"], (double)attributes["dogTailLength"]);
                case "Swan": return new Swan((double)attributes["birdWingSpan"], (string)attributes["swanColor"]);
                case "Crow": return new Crow((double)attributes["birdWingSpan"], (double)attributes["crowWeight"]);
            }

            return null;
        }


    }
}
