using System.Collections.Generic;
using api.Entities;

namespace api.facade
{
	public class ApiFacade : IApiFacade
	{
	  bool IApiFacade.AddUser()
		{
			return false;
		}
		bool IApiFacade.DeleteUser()
		{
			return true;
		}
		bool IApiFacade.UpdateUser()
		{
			return true;
		}
		List<User> IApiFacade.GetUsers()
		{
			return null;
		}
		User IApiFacade.GetUser()
		{
			return null;
		}
	}
}