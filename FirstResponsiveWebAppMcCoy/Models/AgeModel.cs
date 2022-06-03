using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMcCoy.Models
{
    public class AgeModel    
    {
        public DateTime date = DateTime.Now;

        [Required(ErrorMessage = "Please enter a name.")]       
        public string FullName { get; set; }

        [Required(ErrorMessage ="Please enter the year you were born.")]
        [Range(1,2022, ErrorMessage ="please enter a valid year.")]
        public int? BirthYear { get; set; }

        

        //this method does the math to determine how old the individual will be on December 31 of this year
        public int AgeThisYear()
        {            
            int currentYear = date.Year;
            int yearsOld =  currentYear - BirthYear.Value;
            return yearsOld;
        }
    }
}
