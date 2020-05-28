using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.facade;
using api.Entities;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
	private IApiFacade iApiFacade = new ApiFacade();
	// GET: api/users/GetUsers
	[HttpGet("GetUsers")]
	[Produces("application/json")]
	public IActionResult GetUsers()
	{
		List<User> result = iApiFacade.GetUsers();
		if (result.Count > 0)
		{
			return Ok(result);
		}
		return NotFound();
	}
	[HttpPost]
	[Consumes("application/json")]
		public IActionResult AddUser()
	{
		bool result = iApiFacade.AddUser();
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}
}