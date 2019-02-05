using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WebApiWithDapper.Models;
using WebApiWithDapper.Models.Repository;

namespace WebApiWithDapper.Models.DataManager
{
	public class UserAddressManager : IDataRepository<UserAddress, long>
	{
		private readonly string connectionString;
		public UserAddressManager(string connectionString)
		{
			this.connectionString = connectionString;
		}
		public long Add(UserAddress entry)
		{
			throw new NotImplementedException();
		}

		public long Delete(long id)
		{
			throw new NotImplementedException();
		}

		public UserAddress Get(long id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<UserAddress> GetAll()
		{
			IEnumerable<UserAddress> userAddresses;
			using (var connection = new SqlConnection(connectionString))
			{
				userAddresses = connection.Query<UserAddress>("Select UserAddressId, Country, City, State, UserId From UserAddress");
			}
			return userAddresses;
		}

		public long Update(long id, UserAddress b)
		{
			throw new NotImplementedException();
		}
	}
}
