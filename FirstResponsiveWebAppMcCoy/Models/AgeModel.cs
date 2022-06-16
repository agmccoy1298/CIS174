using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMcCoy.Models
{
    public class AgeModel    
    {
        private DateTime date = DateTime.Now;

        [Required(ErrorMessage = "Please enter a name.")]       
        public string FullName { get; set; }

        [Required(ErrorMessage ="Please enter the year you were born.")]
        [Range(1,2022, ErrorMessage ="please enter a valid year.")]
        public int? BirthYear { get; set; }
        public DateTime Date { get => date; set => date = value; }



        //this method does the math to determine how old the individual will be on December 31 of this year
        public static int AgeThisYear(DateTime date, int birthYear)
        {
            if (birthYear > 1 && birthYear < DateTime.Now.Year)
            {
                int currentYear = date.Year;
                int yearsOld = currentYear - birthYear;
                return yearsOld;
            }
            else            
            {
                int yearsOld = 0;
                return yearsOld;
            }
            
        }
    }
}
