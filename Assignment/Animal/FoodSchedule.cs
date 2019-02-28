/* 
 * Magnus Wikhög
 * Assignment 3
 * 2019-02-27
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Animals{

    public class FoodSchedule{
        private List<string> foodDescriptionList;


        FoodSchedule() {
            foodDescriptionList = new List<string>();
        }


        public FoodSchedule(List<string> foodList) {
            foodDescriptionList = new List<string>();
            foreach (string item in foodList) {
                AddFoodScheduleItem(item);
            }
        }


        public int Count { get; }

        bool AddFoodScheduleItem(string item){
            foodDescriptionList.Add(item);
            return true; // TODO why bool?
        }

        bool ChangeFoodScheduleItem(string item, int index) {
            if (ValidateIndex(index)) {
                foodDescriptionList[index] = item;
                return true;
            }
            return false;
        }

        bool DeleteFoodScheduleItem(int index) {
            if( ValidateIndex(index)) {
                foodDescriptionList.RemoveAt(index);
                return true;
            }
            return false;
        }

        string DescribeNoFeedingRequired() {
            return "No feeding required.";
        }

        string GetFoodSchedule(int index) {
            return ValidateIndex(index) ? foodDescriptionList[index] : "";
        }

        bool ValidateIndex(int index) {
            return index < foodDescriptionList.Count;
        }

        override
        public string ToString() => foodDescriptionList.Aggregate((s1, s2) => s1 + "\r\n" + s2);
    }

}
