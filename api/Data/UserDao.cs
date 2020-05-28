using System;
using api.Models;

namespace api.Dao
{
	public static class UserDao {
		private static ApiContext context;

		public static bool create()
		{
			UserDao.context = new ApiContext();
			return true;
		}
		public static bool delete()
		{
			UserDao.context = new ApiContext();
			return true;
		}
		public static bool update()
		{
			UserDao.context = new ApiContext();
			return true;
		}
		public static User readByEmail(string email)
		{
			UserDao.context = new ApiContext();
			return null;
		}
		public static User readAll()
		{
			UserDao.context = new ApiContext();
			return null;
		}

	}
}