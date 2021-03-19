using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public int Protein
        {
            get;
            set;
        }
        public int Carbohydrates
        {
            get;
            set;
        }

        public int Fat
        {
            get;
            set;
        }

        public int Fibre
        {
            get;
            set;
        }


        public int Sugars
        {
            get;
            set;
        }

        public int Sodium
        {
            get;
            set;
        }


        public int Potassium
        {
            get;
            set;
        }


        public int Cholesterol
        {
            get;
            set;
        }


        public int VitaminA
        {
            get;
            set;
        }

        
        public int VitaminC
        {
            get;
            set;
        }

        
        public int Calcium
        {
            get;
            set;
        }
        
        
        public FoodModel()
        {

        }
    }
}
