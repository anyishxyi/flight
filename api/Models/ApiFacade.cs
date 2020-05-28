using System.Collections.Generic;
using System;
using api.Entities;
using api.Dao;

namespace api.facade
{
	public class ApiFacade : IApiFacade
	{
	  bool IApiFacade.AddUser(User user)
		{
			UserDao userDao = new UserDao();
			return userDao.create(user);
		}
		bool IApiFacade.DeleteUser(User user)
		{
			UserDao userDao = new UserDao();
			return userDao.delete(user);
		}
		bool IApiFacade.UpdateUser(User userData)
		{
			return true;
		}
		List<User> IApiFacade.GetUsers()
		{
			return null;
		}
		User IApiFacade.GetUser(string email)
		{
			return null;
		}
	}
}