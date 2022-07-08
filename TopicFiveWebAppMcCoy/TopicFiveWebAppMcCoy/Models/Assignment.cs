using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TopicFiveWebAppMcCoy.Models
{
    public class Assignment
    {
        
        public int AssignmentId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Please enter what class this is")]
        public string ClassName { get; set; }
        

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + AssignmentId.ToString();
    }
}
