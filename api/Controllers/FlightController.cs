using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using api.facade;
using api.Entities;
using api.Data;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Consumes("application/json")]
public class FlightController : ControllerBase
{
	private ApiContext _context;
	private IApiFacade _iApiFacade;
	public FlightController(ApiContext context)
	{
		_context = context;
		_iApiFacade = new ApiFacade(_context);
	}

	// GET: api/Flight/getall
	[HttpGet("all")]
	public IActionResult getall()
	{
		
		List<Flight> result = _iApiFacade.GetFlights();
		if (result == null)
		{
			return NotFound();
		}
		return Ok(result);
	}

	// POST: api/Flight/add
	[HttpPost("add")]
		public IActionResult add(Flight flightData)
	{
		if(flightData == null) {
			return NotFound();
		}
		bool result = _iApiFacade.AddFlight(flightData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}

	// POST: api/flight/update
	[HttpPost("update")]
		public IActionResult update(Flight flightData)
	{
		if(flightData == null) {
			return NotFound();
		}
		bool result = _iApiFacade.UpdateFlight(flightData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}

	// POST: api/flight/delete
	[HttpPost("delete")]
		public IActionResult delete(Flight flightData)
	{
		bool result = _iApiFacade.DeleteFlight(flightData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}
}