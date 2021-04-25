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
        private readonly HospitalContext _context;

        public WeatherForecastController(HospitalContext context)
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
