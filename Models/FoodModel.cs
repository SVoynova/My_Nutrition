using System;

namespace MyNutritionApp.Models
{
    public class FoodModel
    {
        public int Id
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }


        public string Serving
        {
            get;
            set;
        }

        public int CaloriesPerServing
        {
            get;
            set;
        }
        public int TotalCalories
        {
            get { return CaloriesPerServing * Quantity; }
            set { }
        }

        public int Quantity
        {
            get;
            set;
        }

        public double Protein
        {
            get;
            set;
        }
        public double Carbohydrates
        {
            get;
            set;
        }

        public double Fat
        {
            get;
            set;
        }

        public double Fibre
        {
            get;
            set;
        }


        public double Sugars
        {
            get;
            set;
        }

        public double Sodium
        {
            get;
            set;
        }


        public double Potassium
        {
            get;
            set;
        }


        public double Cholesterol
        {
            get;
            set;
        }


        public double VitaminA
        {
            get;
            set;
        }

        
        public double VitaminC
        {
            get;
            set;
        }

        
        public double Calcium
        {
            get;
            set;
        }
        
        
        public FoodModel()
        {

        }
    }
}
