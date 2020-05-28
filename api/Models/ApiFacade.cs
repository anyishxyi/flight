using System.Collections.Generic;
using System;
using api.Entities;
using api.Dao;
using api.Data;

namespace api.facade
{
	public class ApiFacade : IApiFacade
	{
		private UserDao _userDao;
		private FlightDao _flightDao;

		public ApiFacade(ApiContext context)
		{
			_userDao = new UserDao(context);
		}
	  bool IApiFacade.AddUser(User user)
		{
			return _userDao.create(user);
		}
		bool IApiFacade.DeleteUser(User user)
		{
			return _userDao.delete(user);
		}
		bool IApiFacade.UpdateUser(User userData)
		{
			return _userDao.update(userData);
		}
		List<User> IApiFacade.GetUsers()
		{
			return _userDao.readAll();
		}
		User IApiFacade.GetUser(string email)
		{
			return null;
		}
		bool AddFlight(Flight flightData)
		{
			return true;
		}
		bool DeleteFlight(Flight flightData)
		{
			return true;
		}
		bool UpdateFlight(Flight flightData)
		{
			return true;
		}
		List<Flight> GetFlights()
		{
			return null;
		}
		User GetFlight(int id)
		{
			return null;
		}
	}
}