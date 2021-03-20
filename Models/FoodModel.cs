using System;

namespace MyNutritionApp.Models
{
    public class FoodModel
    {
        /// <summary>
        /// ID if the food entry
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// the date of creating the food entry
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// The name of food
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The quantity of food suitable for serving
        /// </summary>
        public string Serving
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of calories of the food per serving
        /// </summary>
        public int CaloriesPerServing
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of calories the user has consumed in total
        /// </summary>
        public int TotalCalories
        {
            get { return CaloriesPerServing * Quantity; }
        }

        /// <summary>
        /// The amount of servings consumed
        /// </summary>
        public int Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of protein per serving, in grams
        /// </summary>
        public double Protein
        {
            get;
            set;
        }

        /// <summary>
        /// The amount carbohydrates per serving, in grams
        /// </summary>
        public double Carbohydrates
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of fats per serving, in grams
        /// </summary>
        public double Fat
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of fiber per serving, in grams
        /// </summary>
        public double Fibre
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of suger per serving, in grams
        /// </summary>
        public double Sugars
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of sodium per serving, in milligrams
        /// </summary>
        public double Sodium
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of potassium per serving, in milligrams
        /// </summary>
        public double Potassium
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of cholesterol per serving, in grams
        /// </summary>
        public double Cholesterol
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of Vatamin A per serving, in grams
        /// </summary>
        public double VitaminA
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of Vatamin C per serving, in grams
        /// </summary>
        public double VitaminC
        {
            get;
            set;
        }

        /// <summary>
        /// The amount of calcium per serving, in grams
        /// </summary>
        public double Calcium
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor for the class FoodModel
        /// </summary>
        public FoodModel()
        {

        }
    }
}
