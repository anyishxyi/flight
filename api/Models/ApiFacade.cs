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
			_flightDao = new FlightDao(context);
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
		bool IApiFacade.AddFlight(Flight flightData)
		{
			return _flightDao.create(flightData);
		}
		bool IApiFacade.DeleteFlight(Flight flightData)
		{
			return _flightDao.delete(flightData);
		}
		bool IApiFacade.UpdateFlight(Flight flightData)
		{
			return _flightDao.update(flightData);
		}
		List<Flight> IApiFacade.GetFlights()
		{
			return _flightDao.readAll();
		}
		User IApiFacade.GetFlight(int id)
		{
			return null;
		}
	}
}