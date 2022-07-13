using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopicFiveWebAppMcCoy.Models
{
    public class Country
    {
        [Key]
        public string CountryID { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; }
        public Category Category { get; set; }
        public string FlagImage { get; set; }

    }
}
