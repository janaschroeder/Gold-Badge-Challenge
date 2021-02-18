//using System;

using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Challenge_1_Repo
{
    public class Meal_Repo

    { 
    //static void Main(string[] args)

    //{ 
        private readonly List<Meal> _menu = new List<Meal>();

        public int CountofMeals()
        {
            //            GetCount;
            //{
            return _menu.Count;
            //}
        }

        //Create
        public bool AddMealToMenu(Meal item)
        {
            int startingCount = _menu.Count;
            _menu.Add(item);
            bool wasAdded = _menu.Count > startingCount;
            return wasAdded;
        }

        //Read
        public List<Meal> GetMenu()
        {
            return _menu;
        }

        /*
        static void CheckCanDelete(string mealNumberInput, string mealNumber)
        {
            if (mealNumberInput != mealNumber)
            {
                throw new System.Exception("There is not a meal with that number.");
            }
            else
            {        
        .remove(Meal);
                Console.WriteLine("Meal deleted");
            }
        }
        */
        //{
        //mealNumber//Input !== mealNumber
        //System.Console.WriteLine(There is not a meal with that number.You will need to try again.);
        //}
        //{
        //return content;

        //public bool DeleteItem(string mealNumber) 
        //        {
        // Meal itemToDelete = GetItemByMealNumber(mealNumber);
        //            return _menu.Remove(itemToDelete);
        //}


        public void SeedContent()
        {
            Meal kiddieMeal = new Meal(
    "1",
    "Kiddie Meal",
    "Just right for youngsters and smaller appetites",
    "Small Cheeseburger, Small Fries, Small Coke",
    2.95m
                    );
            Meal adultCombo = new Meal(
                "2",
                "Adult Combo",
                "Classic American fare",
                "Cheeseburger, Fries, Coke",
                3.95m
                );
            Meal cheeseburgerSpecial = new Meal(
    "3",
    "Cheeseburger Special",
    "What you get no matter what you order",
    "Cheeseburger, Cheeseburger, Cheeseburger",
    5.95m
    );

            _menu.Add(kiddieMeal);
            _menu.Add(adultCombo);
            _menu.Add(cheeseburgerSpecial);
        }
    }

}

