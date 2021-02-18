//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_Repo
{
    public class Meal
    {
        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string IngredientList { get; set; }
        public decimal Price { get; set; }

        public Meal() { }
        public Meal(string mealNumber, string mealName, string description, string ingredientList, decimal price )
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            IngredientList = ingredientList;
            Price = price;
        }
    }
}

