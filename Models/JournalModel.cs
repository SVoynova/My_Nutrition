using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Nutrition.Models
{
    public class JournalModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Thoughts { get; set; }

        public string Gratitudes { get; set; }

        public string Concerns { get; set; }

        public string Questions { get; set; }

        public JournalModel()
        {
        
        }
    }
}
