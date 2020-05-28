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

	// GET: api/user/getall
	[HttpGet("all")]
	public IActionResult getall()
	{
		
		List<User> result = _iApiFacade.GetUsers();
		if (result == null)
		{
			return NotFound();
		}
		return Ok(result);
	}

	// POST: api/user/add
	[HttpPost("add")]
		public IActionResult add(User userData)
	{
		if(userData == null) {
			return NotFound();
		}
		bool result = _iApiFacade.AddUser(userData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}

	// POST: api/user/update
	[HttpPost("update")]
		public IActionResult update(User userData)
	{
		if(userData == null) {
			return NotFound();
		}
		bool result = _iApiFacade.UpdateUser(userData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}

	// POST: api/user/delete
	[HttpPost("delete")]
		public IActionResult delete(User userData)
	{
		bool result = _iApiFacade.DeleteUser(userData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}
}