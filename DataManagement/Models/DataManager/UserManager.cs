
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WebApiWithDapper.Models;
using WebApiWithDapper.Models.Repository;

namespace WebApiWithDapper.Models.DataManager
{
	public class UserManager : IDataRepository<Users, long>
	{
		private readonly string connectionString;


		public UserManager(string connectionString)
		{
			this.connectionString = connectionString;
		}
		public long Add(Users entry)
		{
			long entryid;
			using (var connection = new SqlConnection(connectionString))
			{
				entryid = connection.Execute("INSERT INTO USERS (UserId, FirstName, CreatedAt, IsActive) VALUES(@userId, @firstName, @CreatedAt, @IsActive)", new { entry.UserId, entry.FirstName, entry.CreatedAt, entry.IsActive });
			}
			return entryid;
		}

		public long Delete(long id)
		{
			long entryid;
			using (var connection = new SqlConnection(connectionString))
			{
				entryid = connection.Execute("DELETE FROM Users Where UserId = @UserId", new { UserId = id });
			}
			return entryid;
		}

		public Users Get(long id)
		{
			Users user = null;
			using (var connection = new SqlConnection(connectionString))
			{
				user = connection.QuerySingle<Users>("Select UserId, FirstName, LastName FROM Users Where UserId = @UserId", new { UserId =id });
			}
			return user;
		}

		public IEnumerable<Users> GetAll()
		{
			IEnumerable<Users> users = null;

			using (var connection = new SqlConnection(connectionString))
			{
				users = connection.Query<Users>("Select UserId, FirstName, LastName FROM Users");
			}
			return users;
		}

		public long Update(long id, Users b)
		{
			long entryid;
			using (var connection = new SqlConnection(connectionString))
			{
				entryid = connection.Execute("UPDATE Users Set FirstName = @FirstName Where UserId = @UserId", new { b.FirstName, id });
			}
			return entryid;
		}
	}
}
