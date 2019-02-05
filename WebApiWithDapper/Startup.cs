
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiWithDapper.Models;
using WebApiWithDapper.Models.DataManager;
using WebApiWithDapper.Models.Repository;

namespace WebApiWithDapper
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			services.AddScoped<IDataRepository<Users, long>, UserManager>();
			services.AddScoped<IDataRepository<UserAddress, long>, UserAddressManager>();
			services.AddTransient<IDataRepository<Users, long>>(f => new UserManager(Configuration["ConnectionString:UserApplicationDB"]));
			services.AddTransient<IDataRepository<UserAddress, long>>(f => new UserAddressManager(Configuration["ConnectionString:UserApplicationDB"]));


			services.AddCors();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}
