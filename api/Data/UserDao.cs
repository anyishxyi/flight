using System.Collections.Generic;
using api.Models;

namespace api.Dao
{
	public class UserDao: ModelDao<User> {
		private ApiContext context;

		public override bool create(User user)
		{
			this.context = new ApiContext();
			return true;
		}
		public override bool delete(User user)
		{
			this.context = new ApiContext();
			return true;
		}
		public override bool update(User user)
		{
			this.context = new ApiContext();
			return true;
		}
		public override List<User> readAll()
		{
			this.context = new ApiContext();
			return null;
		}
		public User readByEmail(string email)
		{
			this.context = new ApiContext();
			return null;
		}

	}
}