using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using api.Entities;
using api.Data;

namespace api.Dao
{
	public class ReservationDao: ModelDao<Reservation> {
		private ApiContext _context;
		public ReservationDao(ApiContext context)
		{
			_context = context;
		}

		public override bool create(Reservation reservation)
		{
			EntityEntry uResponse = _context.Reservation.Add(reservation);
			_context.SaveChanges();
			return uResponse == null ? false : true;
		}
		public override bool delete(Reservation reservation)
		{
			// this.context = new ApiContext();
			return true;
		}
		public override bool update(Reservation reservation)
		{
			// this.context = new ApiContext();
			return true;
		}
		public override List<Reservation> readAll()
		{
			List<Reservation> reservations = _context.Reservation.ToList();
			return reservations == null ? new List<Reservation>() : reservations;
		}
		public Reservation readByEmail(string email)
		{
			// this.context = new ApiContext();
			return null;
		}
	}
}