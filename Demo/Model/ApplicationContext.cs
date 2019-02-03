using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Model
{

	//Code-First development approach requires us to create a data access context class that inherits from the DbContext class.
	// Our ApplicationContext class will act as a service.This service will be registered with Dependency Injection(DI) during application startup.
	//This would enable our API Controller or other services gain access to the ApplicationContext via constructor parameters or properties.
	public class ApplicationContext: DbContext
	{

		// A DbContext must have an instance of DbContextOptions in order to execute.
		// This can be configured by overriding OnConfiguring, or supplied externally via a constructor argument.
		public ApplicationContext(DbContextOptions opts) : base(opts)
		{
		}

		public DbSet<Users> Users { get; set; }

		public DbSet<UserAddress> UserAddresses { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		}

	}
}
