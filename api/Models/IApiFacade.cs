using System.Collections.Generic;
using api.Entities;

namespace api.facade
{
	interface IApiFacade 
	{
		//User
		bool AddUser(User userData);
		bool DeleteUser(User userData);
		bool UpdateUser(User userData);
		List<User> GetUsers();
		User GetUser(string email);
		//Flight
		bool AddFlight(Flight flightData);
		bool DeleteFlight(Flight flightData);
		bool UpdateFlight(Flight flightData);
		List<Flight> GetFlights();
		User GetFlight(int id);
		//Reservation
		bool AddReservation(Reservation reservationData);
		bool DeleteReservation(Reservation reservationData);
		bool UpdateReservation(Reservation reservationData);
		List<Reservation> GetReservations();
		Reservation GetReservation(int id);
	}
}
