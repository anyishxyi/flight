using System.Collections.Generic;
using api.Entities;

namespace api.facade
{
	interface IApiFacade 
	{
		bool AddUser();
		bool DeleteUser();
		bool UpdateUser();
		List<User> GetUsers();
		User GetUser();
	}
}
