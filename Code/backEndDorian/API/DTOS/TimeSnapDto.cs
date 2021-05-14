using System;
using API.Entities;

namespace API.DTOS
{
    public class TimeSnapDto
    {
        public int TimeTableID {get; set;}

        public int Speed {get; set;}

        public DateTime Time {get; set; }

        public int WordLength {get; set; }

        public int LastWordLength {get; set; }

        public int NextWordLength {get; set; }

        public bool HasUserLostTheWord {get; set; }

        public int UserId { get; set;}
        public AppUser AppUser {get; set;}
    }
}