using System;
using System.Collections.Generic;
using api.Models;

namespace api.Dao
{
	abstract class ModelDao<T>
	{
		public abstract bool create(T obj);
		public abstract List<T> readAll();
		public abstract bool update(string email);
		public abstract bool delete(string email);
	}
}