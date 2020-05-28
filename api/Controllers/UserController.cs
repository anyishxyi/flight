using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.facade;
using api.Entities;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Consumes("application/json")]
public class UserController : ControllerBase
{
	// GET: api/users/GetUsers
	[HttpGet("GetUsers")]
	public IActionResult GetUsers()
	{
		IApiFacade iApiFacade = new ApiFacade();
		List<User> result = iApiFacade.GetUsers();
		if (result.Count() > 0)
		{
			return Ok(result);
		}
		return NotFound();
	}

	[HttpPost]
		public IActionResult AddUser()
	{
		IApiFacade iApiFacade = new ApiFacade();
		bool result = iApiFacade.AddUser();
		if (result)
		{
			return Ok(result);
		}
		return NotFound();
	}
}