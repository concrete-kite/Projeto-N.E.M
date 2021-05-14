using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {   
        [Key]
        public int UserId { get; set; }
        public string Name {get; set; }
        public List<TimeTable> TimeTable {get; set;}
    }
}