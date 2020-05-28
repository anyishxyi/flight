using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using api.facade;
using api.Entities;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Consumes("application/json")]
public class UserController : ControllerBase
{
	// GET: api/user/getall
	[HttpGet("all")]
	public IActionResult getall()
	{
		IApiFacade iApiFacade = new ApiFacade();
		List<User> result = iApiFacade.GetUsers();
		if (result == null || result.Count() <= 0)
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
		IApiFacade iApiFacade = new ApiFacade();
		bool result = iApiFacade.AddUser(userData);
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
		IApiFacade iApiFacade = new ApiFacade();
		bool result = iApiFacade.UpdateUser(userData);
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
		IApiFacade iApiFacade = new ApiFacade();
		bool result = iApiFacade.DeleteUser(userData);
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}
}