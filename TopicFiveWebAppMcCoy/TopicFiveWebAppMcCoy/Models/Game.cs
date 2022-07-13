using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopicFiveWebAppMcCoy.Models
{
    public class Game
    {
        [Key]
        public string GameID { get; set; }
        public string Name { get; set; }
    }
}
