using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class TimeTable
    {
        public int TimeTableID {get; set;}

        public int Speed {get; set;}

        public DateTime Time {get; set; }

        public int WordLength {get; set; }

        public int LastWordLength {get; set; }

        public int NextWordLength {get; set; }

        public bool HasUserLostTheWord {get; set; }


        // Relation to AppUser
        [ForeignKey("UserID")]
        public int UserId { get; set;}
        public AppUser AppUser {get; set;}
    }
}