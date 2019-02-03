using Demo.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Model.DataManager
{
	public class UserManager : IDataRepository<Users, long>
	{
		ApplicationContext context;


		public UserManager(ApplicationContext context)
		{
			this.context = context;
		}
		public long Add(Users entry)
		{
			context.Users.Add(entry);
			long id = context.SaveChanges();
			return id;
		}

		public long Delete(long id)
		{
			long userId = 0;

			var user = context.Users.FirstOrDefault(u => u.UserId == id);
			if (user != null)
			{
				context.Users.Remove(user);
				userId = context.SaveChanges();
			}
			return userId;
		}

		public Users Get(long id)
		{
			var res = context.Users.Where(u => u.UserId == id).Include(u => u.UserAddresses).FirstOrDefault();
			return res;
		}

		public IEnumerable<Users> GetAll()
		{
			var res = context.Users.Include(u => u.UserAddresses).ToList();
			return res;
		}

		public long Update(long id, Users b)
		{
			throw new NotImplementedException();
		}
	}
}
