using DemoDotNetCore.Models;
using DemoDotNetCore.Repositories;
using EMS.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS
{
	public class Startup
	{
		private IConfiguration _configuration;

		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContextPool<AppDatabaseContext>(options => options.UseSqlServer(_configuration.GetConnectionString("EmployeeDBConnection")));
			services.AddIdentity<IdentityUser, IdentityRole>(options => {
					options.Password.RequireDigit = false;
				options.Password.RequiredLength = 4;
				options.Password.RequireDigit = false;
				options.Password.RequireUppercase = false;

				}).AddEntityFrameworkStores<AppDatabaseContext>();
			services.AddScoped<IEmployeeRepository, MockEmployeeRepository>();
			services.AddMvc(options => options.EnableEndpointRouting = false);
			
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				
			}

			//app.UseAuthentication();

			app.UseMvc(rc => rc.MapRoute("default", "{controller=home}/{action=index}"));
		
		}
	}
}
