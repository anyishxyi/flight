using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using api.Entities;
using api.Data;

namespace api.Dao
{
	public class UserDao: ModelDao<User> {
		private ApiContext _context;
		public UserDao(ApiContext context)
		{
			_context = context;
		}

		public override bool create(User user)
		{
			EntityEntry uResponse = _context.User.Add(user);
			_context.SaveChanges();
			return uResponse == null ? false : true;
		}
		public override bool delete(User user)
		{
			// this.context = new ApiContext();
			return true;
		}
		public override bool update(User user)
		{
			// this.context = new ApiContext();
			return true;
		}
		public override List<User> readAll()
		{
			List<User> users = _context.User.ToList();
			return users == null ? new List<User>() : users;
		}
		public User readByEmail(string email)
		{
			// this.context = new ApiContext();
			return null;
		}

	}
}