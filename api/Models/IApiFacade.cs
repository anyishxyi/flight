using System.Collections.Generic;
using api.Entities;

namespace api.facade
{
	interface IApiFacade 
	{
		bool AddUser(User userData);
		bool DeleteUser(User userData);
		bool UpdateUser(User userData);
		List<User> GetUsers();
		User GetUser(string email);
	}
}
