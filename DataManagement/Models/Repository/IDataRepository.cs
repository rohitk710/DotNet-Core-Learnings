using System.Collections.Generic;

namespace WebApiWithDapper.Models.Repository
{
	//Basic generic repository for handling data access within our application.
	// Comes by default in Java apparently. Here the first paramerter is the class/Entity and second is the primary key in that class/Entity.
	public interface IDataRepository<TEntity, U> where TEntity : class
	{
		IEnumerable<TEntity> GetAll();
		TEntity Get(U id);
		long Add(TEntity entry);
		long Update(U id, TEntity b);
		long Delete(U id);
	}
}
