using Challenge_1_Repo;
using System;
using System.Collections.Generic;

namespace Challenge_1_UI
{
    class ProgramUI1
    {
        public readonly Meal_Repo _repo = new Meal_Repo();
        public readonly List<Meal> _menu = new List<Meal>();
        public bool continueToRun = true;
        public readonly string userInput = Console.ReadLine();
        public void Run()
        {

            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome, Chef. Enter a key to continue.");
                Console.ReadKey();
                Console.WriteLine("Would you like to:\n" +
                "1. See the current menu \n" +
             "2. Add a meal to the menu  \n" +
             "3. Remove a meal from the menu \n" +
                 "4. Exit \n" +
                "Please enter a number between 1 and 4.");
                ;

                switch (userInput)
                {
                    case "1":
                        ShowCafeMenu1();
                        _repo.SeedContent();
                        break;
                    case "2":
                        CreateNewMeal();
                        break;
                    
                        
                        case "3":
                        DeleteMeal();
                        _repo.SeedContent();
                        break;
                    case "4":       
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("INVALID! Please enter a number between 1 and 4.");
                        Console.ReadKey();
                        break;

                }
            }
        }
        void ShowCafeMenu1()
        {
            Console.Clear();
            List<Meal> listOfMeals = _repo.GetMenu();

            foreach (Meal Item in listOfMeals)
            {
                DisplayContent(Item);
            }
            Console.ReadKey();
        }

        void DisplayContent(Meal item)
        {
            Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                $"Meal Name: {item.MealName}\n" +
                $"Description: {item.Description}\n" +
                                            $"Ingredients: {item.IngredientList}\n" +
                                            $"Price: ${item.Price}");
        }

        void CreateNewMeal()
        {
            Console.Clear();
            Console.WriteLine("What is the meal ID?");
            string mealNumber = Console.ReadLine();
            //var res = System.Convert.ToInt32(mealNumber);
            Console.WriteLine("What do you want to call your new creation?");
            string mealName = Console.ReadLine();
            Console.WriteLine("Please enter a description of the new meal: ");
            string description = Console.ReadLine();
            Console.WriteLine("Please enter the ingredients: ");
            string ingredientList = Console.ReadLine();
            Console.WriteLine("What is the price of this meal? ");
            string priceInput = Console.ReadLine();
            var result = System.Convert.ToDecimal(priceInput);
            Meal feast = new Meal(mealNumber,
                                  mealName,
                                  description,
                                  ingredientList,
                                  result);

            _repo.AddMealToMenu(feast);
        }

        //void DeleteMeal()
        //{
        /*//_repo.GetItemByMealNumber(string mealNumber, string mealNumberInput);
        {
            Console.Clear();
            ShowCafeMenu1();
            Console.WriteLine("Please enter the meal number of the item you want to delete.");
            string mealNumberInput = Console.ReadLine();
            if (mealNumberInput == mealNumber) 
            {
                _repo.DeleteItem(mealNumber);
            }
        }
        */

    }


}


