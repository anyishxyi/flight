using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using api.Entities;
using api.Data;

namespace api.Dao
{
	public class FlightDao: ModelDao<Flight> {
		private ApiContext _context;
		public FlightDao(ApiContext context)
		{
			_context = context;
		}

		public override bool create(Flight flight)
		{
			EntityEntry uResponse = _context.Flight.Add(flight);
			_context.SaveChanges();
			return uResponse == null ? false : true;
		}
		public override bool delete(Flight flight)
		{
			// this.context = new ApiContext();
			return true;
		}
		public override bool update(Flight flight)
		{
			// this.context = new ApiContext();
			return true;
		}
		public override List<Flight> readAll()
		{
			List<Flight> flights = _context.Flight.ToList();
			return flights == null ? new List<Flight>() : flights;
		}
		public Flight readByEmail(string email)
		{
			// this.context = new ApiContext();
			return null;
		}

	}
}