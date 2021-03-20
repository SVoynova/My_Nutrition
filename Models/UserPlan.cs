using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyNutritionApp.Models
{
    public class UserPlan
    {
        /// <summary>
        /// ID of the user
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        //[Required(ErrorMessage = "Please enter a date!")]

        /// <summary>
        /// The date of the progress check
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }


        [Required(ErrorMessage = "Please enter your sex!")]
        /// <summary>
        /// User's sex
        /// </summary>
        public string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        [Required(ErrorMessage = "Please enter your age!")]
        /// <summary>
        /// User's age
        /// </summary>
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        [Required(ErrorMessage = "Please enter your height!")]
        /// <summary>
        /// User's height in cm
        /// </summary>
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }


        [Required(ErrorMessage = "Please enter your current weight!")]
        /// <summary>
        /// User's current weight in kg
        /// </summary>
        private int currentWeight;
        public int CurrentWeight
        {
            get { return currentWeight; }
            set { currentWeight = value; }
        }

        [Required(ErrorMessage = "Please enter your goal weight!")]
        /// <summary>
        /// User's goal weight in kg
        /// </summary>
        private int goalWeight;
        public int GoalWeight
        {
            get { return goalWeight; }
            set { goalWeight = value; }
        }


        [Required(ErrorMessage = "Please select your activity level!")]
        /// <summary>
        /// User's activity level
        /// </summary>
        private string activityLevel;
        public string ActivityLevel
        {
            get { return activityLevel; }
            set { activityLevel = value; }
        }


        [Required(ErrorMessage = "Please select the desired plan!")]
        /// <summary>
        /// User's preference on the intensity of the plan
        /// </summary>
        private string intensityOfThePlan;
        public string IntensityOfThePlan
        {
            get { return intensityOfThePlan; }
            set { intensityOfThePlan = value; }
        }

        /// <summary>
        /// User's Basal Metabolict calculated using the Harris-Benedict equation
        /// </summary>
        public int BMR
        {
            get
            {
                int sexCoefficent = 0;
                switch (sex)
                {
                    case "female": sexCoefficent = -161; break;
                    case "male": sexCoefficent = 5; break;
                }
                return Convert.ToInt32((10 * currentWeight) + (6.25 * height) - (5 * age) + sexCoefficent);
            }
        }


        /// <summary>
        /// User's estimated daily calorie needs
        /// </summary>
        public int DailyCalorieNeeds
        {
            get
            {
                double activityCoefficient = 0;
                switch (activityLevel)
                {
                    case "Sedentary": activityCoefficient = 1.2; break;
                    case "Lightly active": activityCoefficient = 1.375; break;
                    case "Moderately active": activityCoefficient = 1.55; break;
                    case "Very active": activityCoefficient = 1.725; break;
                    case "Extra active": activityCoefficient = 1.9; break;
                }

                int caloriesToReachGoal = 0;
                switch (intensityOfThePlan)
                {
                    case "Lose 0.5kg per week": caloriesToReachGoal = -500; break;
                    case "Lose 1kg per week": caloriesToReachGoal = -1000; break;
                    case "Maintain current weight": caloriesToReachGoal = 0; break;
                    case "Gain 0.5kg per week": caloriesToReachGoal = 500; break;
                    case "Gain 1kg per week": caloriesToReachGoal = 1000; break;
                }
                return (int)Math.Ceiling(BMR * activityCoefficient + caloriesToReachGoal);
            }
        }


        /*
        Calculating Daily Calorie Needs
        ________________________________
        Sedentary(little or no exercise) : Calorie-Calculation = BMR x 1.2
        Lightly active(light exercise/sports 1-3 days/week) : Calorie-Calculation = BMR x 1.375
        Moderately active(moderate exercise/sports 3-5 days/week) : Calorie-Calculation = BMR x 1.55
        Very active(hard exercise/sports 6-7 days a week) : Calorie-Calculation = BMR x 1.725
        Extra active(very hard exercise/sports & a physical job) : Calorie-Calculation = BMR x 1.9
        */


        /// <summary>
        /// The percentage of carbohydrates from the daily calorie needs
        /// </summary>
        public int CarbohydratesPercentage
        {

            get
            {
                return 50;
            }
        }

        /// <summary>
        /// The daily consumption of carbohydrates in grams, based on the percentage of daily carbohydrates
        /// </summary>
        public int Carbohydrates
        {
            get
            {
                return (int)Math.Ceiling(0.5 * DailyCalorieNeeds / 4);
            }
        }

        /// <summary>
        /// The percentage of protein from the daily calorie needs
        /// </summary>
        public int ProteinPercentage
        {
            get
            {
                return 25;
            }
        }
        /// <summary>
        /// The daily consumption of protein in grams, based on the percentage of daily protein
        /// </summary>
        public int Protein
        {
            get
            {
                return (int)Math.Ceiling(0.25 * DailyCalorieNeeds / 4);
            }
        }

        /// <summary>
        /// The percentage of fats from the daily calorie needs
        /// </summary>
        public int FatPercentage
        {
            get
            {
                return 25;
            }
        }

        /// <summary>
        /// The daily consumption of fats in grams, based on the percentage of daily fats
        /// </summary>
        private int fats;
        public int Fats
        {
            get
            {
                fats = (int)Math.Ceiling(0.25 * DailyCalorieNeeds / 9);
                return fats;
            }
        }

        /// <summary>
        /// The daily consumption of fiber in grams, based on the calorie needs
        /// </summary>
        private int dailyFibre;

        public int DailyFibre
        {
            get
            {
                dailyFibre = (int)Math.Ceiling(DailyCalorieNeeds * 0.014);
                return dailyFibre;
            }
        }

        /// <summary>
        /// The daily sugar intake in grams, based on gender
        /// </summary>
        public int DailySugars
        {
            get
            {
                switch (sex)
                {
                    case "female": return 24;
                    case "male": return 36;
                }
                return 0;
            }

        }

        /// <summary>
        /// The daily consumption of sodium in milligrams
        /// </summary>
        public double DailySodium
        {
            get
            {
                return 2300;
            }
        }

        /// <summary>
        /// The daily consumption of potassium in milligrams
        /// </summary>
        public double DailyPotassium
        {
            get
            {
                return 3500;
            }
        }

        /// <summary>
        /// The daily consumption of cholesterol in milligrams
        /// </summary>
        public double DailyCholesterol
        {
            get
            {
                return 300;
            }
        }

        /// <summary>
        /// The daily consumption of vitamin A in milligrams, based on the sex of the user
        /// </summary>
        public double DailyVitaminA
        {
            get
            {
                switch (sex)
                {
                    case "female": return 0.7;
                    case "male": return 0.9;
                }
                return 0;
            }

        }

        /// <summary>
        /// The daily consumption of vitamin C in milligrams, based on the sex of the user
        /// </summary>
        public double DailyVitaminC
        {
            get
            {
                if (age > 16)
                {
                    switch (sex)
                    {
                        case "female": return 75;
                        case "male": return 90;
                    }
                }
                return 55;

            }
        }

        /// <summary>
        /// The daily consumption of calcium in grams
        /// </summary>
        public double DailyCalcium
        {
            get
            {
                return 600;
            }
        }

        /// <summary>
        /// The daily consumption of water in liters, based on the user's goal weight
        /// </summary>
        public double DailyWater
        {
            get
            {
                return Math.Round(0.033 * CurrentWeight, 2);
            }
        }

        /// <summary>
        /// Constructor for the class UserPlan
        /// </summary>
        public UserPlan()
        {

        }
    }
}

