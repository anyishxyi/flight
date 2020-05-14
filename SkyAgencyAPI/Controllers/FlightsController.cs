using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SkyAgencyAPI.Models;

namespace SkyAgencyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController : ControllerBase
    {

        /*private readonly ILogger<FlightsController> _logger;

        public FlightsController(ILogger<FlightsController> logger)
        {
            _logger = logger;
        }*/

        [HttpGet]
        public IEnumerable<Models.Flight> Get()
        {
           using (var ctx = new Flight_agencyContext()) 
            {
                return ctx.Flight.ToList();
            }
        }

        [HttpGet]
        [Route("/flight/{id?}")]
        public Models.Flight GetFlight(int? id)
        {
            using(var ctx = new Flight_agencyContext())
            {
                return ctx.Flight.Find(id);
            }
        }

        [HttpGet]
        [Route("/flight/startlocation/{startLocation?}")]
        public Models.Flight GetFlightByStartLocation(string? startLocation)
        {
            using(var ctx = new Flight_agencyContext())
            {
                var flight = ctx.Flight.ToList();
                return flight.Where(flightTicket => flightTicket.StartLocation == startLocation).FirstOrDefault<Flight>();
            }
        }
    }
}
