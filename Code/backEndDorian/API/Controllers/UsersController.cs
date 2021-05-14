using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using API.DTOS;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("dorian/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id) 
        {
            return _context.Users.Find(id);
        }

        [HttpPost("/postTable")]
        public async Task<ActionResult<TimeTable>> AddTimeSnap(TimeSnapDto timeSnap)
        {
            var newTimeSnap = new TimeTable{
                TimeTableID = timeSnap.TimeTableID,
                Speed = timeSnap.Speed,
                Time = timeSnap.Time,
                WordLength = timeSnap.WordLength,
                LastWordLength = timeSnap.LastWordLength,
                NextWordLength = timeSnap.NextWordLength,
                HasUserLostTheWord = timeSnap.HasUserLostTheWord,
                UserId = timeSnap.UserId
            };

            var timeTableID = timeSnap.TimeTableID;
            _context.TimeTables.Add(newTimeSnap);
            await _context.SaveChangesAsync();
            return newTimeSnap;
        }
    }
}