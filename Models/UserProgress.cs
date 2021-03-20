using System;

namespace My_Nutrition.Models
{
    public class UserProgress
    {
        /// <summary>
        /// Id of the progress entry
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Date and time of posting the progress data
        /// </summary>
        public DateTime Date
        {
            get; set;
        }

        /// <summary>
        /// User's current weight  in kg
        /// </summary>
        public double Weight
        {
            get;
            set;
        }

        /// <summary>
        /// User's current waist measurements
        /// </summary>
        public double WaistMeasurements
        {
            get;
            set;
        }

        /// <summary>
        /// User's current arm measurements in cm
        /// </summary>
        public double ArmMeasurements 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// User's current leg measurements in cm
        /// </summary>
        public double LegMeasurements 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Constructor for the class UserProgress
        /// </summary>
        public UserProgress()
        {

        }
    }
}
