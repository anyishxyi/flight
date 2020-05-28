using System.Collections.Generic;

namespace api.Dao
{
	public abstract class ModelDao<T>
	{
		public abstract bool create(T obj);
		public abstract List<T> readAll();
		public abstract bool update(T obj);
		public abstract bool delete(T obj);
	}
}