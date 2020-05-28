using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.facade;
using api.Entities;
using api.Data;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Consumes("application/json")]
public class ReservationController : ControllerBase
{
	private ApiContext _context;
	private IApiFacade _iApiFacade;
	public ReservationController(ApiContext context)
	{
		_context = context;
		_iApiFacade = new ApiFacade(_context);
	}

	// GET: api/reservation/getall
	[HttpGet("all")]
	public IActionResult getall()
	{
		
		List<Reservation> result = _iApiFacade.GetReservations();
		if (result == null)
		{
			return NotFound();
		}
		return Ok(result);
	}

	// POST: api/reservation/add
	[HttpPost("add")]
		public IActionResult add(Reservation resData)
	{
		if(resData == null) {
			return NotFound();
		}
		bool result = _iApiFacade.AddReservation(resData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}

	// POST: api/reservation/update
	[HttpPost("update")]
		public IActionResult update(Reservation resData)
	{
		if(resData == null) {
			return NotFound();
		}
		bool result = _iApiFacade.UpdateReservation(resData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}

	// POST: api/reservation/delete
	[HttpPost("delete")]
		public IActionResult delete(Reservation resData)
	{
		bool result = _iApiFacade.DeleteReservation(resData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}
}