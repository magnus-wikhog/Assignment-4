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
    /// A class for storing food schedules.
    /// </summary>
    public class FoodSchedule{
        private List<string> foodDescriptionList;

        /// <summary>
        /// Default constructor for a food schedule.
        /// </summary>
        FoodSchedule() {
            foodDescriptionList = new List<string>();
        }

        /// <summary>
        /// This constructor creates a food schedule from the supplied List of items.
        /// </summary>
        /// <param name="foodList"></param>
        public FoodSchedule(List<string> foodList) {
            foodDescriptionList = new List<string>();
            foreach (string item in foodList) {
                AddFoodScheduleItem(item);
            }
        }

        /// <summary>
        /// Returns the number of items in the food schedule.
        /// </summary>
        public int Count { get; }


        /// <summary>
        ///  Adds an item to the food schedule.
        /// </summary>
        bool AddFoodScheduleItem(string item){
            foodDescriptionList.Add(item);
            return true; // TODO why bool?
        }

        /// <summary>
        /// Replaces an item in the food schedule list.
        /// </summary>
        bool ChangeFoodScheduleItem(string item, int index) {
            if (ValidateIndex(index)) {
                foodDescriptionList[index] = item;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes an item in the food schedule list.
        /// </summary>
        bool DeleteFoodScheduleItem(int index) {
            if( ValidateIndex(index)) {
                foodDescriptionList.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a string that represents "No feeding required".
        /// </summary>
        string DescribeNoFeedingRequired() {
            return "No feeding required.";
        }


        /// <summary>
        /// Returns an item from the food schedule.
        /// </summary>
        string GetFoodSchedule(int index) {
            return ValidateIndex(index) ? foodDescriptionList[index] : "";
        }


        /// <summary>
        /// Returns true if the given index is valid/within bounds, false otherwise.
        /// </summary>
        bool ValidateIndex(int index) {
            return index < foodDescriptionList.Count;
        }

        /// <summary>
        /// Returns the entire food schedule list as a string, with each item separated by newline.
        /// </summary>
        override
        public string ToString() => foodDescriptionList.Aggregate((s1, s2) => s1 + "\r\n" + s2);
    }

}
