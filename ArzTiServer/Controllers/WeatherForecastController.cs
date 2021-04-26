using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ArzTiServer.Models;

namespace ArzTiServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherDbContext _context;

        public WeatherForecastController(WeatherDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var users = _context.Users;
            return users.ToArray<User>();
        }
    }
}
