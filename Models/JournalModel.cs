using System;

namespace My_Nutrition.Models
{
    public class JournalModel
    {
        /// <summary>
        /// ID of journal entry
        /// </summary>
        public int Id 
        { 
            get;
            set; 
        }

        /// <summary>
        /// The data on wich the enty is made
        /// </summary>
        public DateTime Date 
        { 
            get; 
            set;
        }

        /// <summary>
        /// The user can write down his thoughts
        /// </summary>
        public string Thoughts 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// The user can expresses his gratitudes
        /// </summary>
        public string Gratitudes 
        { 
            get;
            set; 
        }

        /// <summary>
        /// The user can share his concerns
        /// </summary>
        public string Concerns 
        { 
            get;
            set;
        }

        /// <summary>
        /// The user can ask questions
        /// </summary>
        public string Questions 
        { 
            get;
            set;
        }

        /// <summary>
        /// Constructor for the class JournalModel
        /// </summary>
        public JournalModel()
        {

        }
    }
}
