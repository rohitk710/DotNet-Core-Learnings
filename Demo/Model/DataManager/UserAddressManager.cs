using Demo.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Model.DataManager
{
	public class UserAddressManager : IDataRepository<UserAddress, long>
	{
		ApplicationContext context;


		public UserAddressManager(ApplicationContext context)
		{
			this.context = context;
		}
		public long Add(UserAddress entry)
		{
			context.UserAddresses.Add(entry);
			long id = context.SaveChanges();
			return id; ;
		}

		public long Delete(long id)
		{
			long userAddressId = 0;

			var usersAddress = context.UserAddresses.FirstOrDefault(u => u.UserAddressId == id);
			if(usersAddress != null)
			{
				context.UserAddresses.Remove(usersAddress);
				userAddressId = context.SaveChanges();
			}
			return userAddressId;
		}

		public UserAddress Get(long id)
		{
			var res = context.UserAddresses.Where(u => u.UserAddressId == id).FirstOrDefault();
			return res;
		}

		public IEnumerable<UserAddress> GetAll()
		{
			var res = context.UserAddresses.ToList();
			return res;
		}

		public long Update(long id, UserAddress b)
		{
			throw new NotImplementedException();
		}
	}
}
