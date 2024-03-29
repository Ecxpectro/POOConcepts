using Db;
using Db.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace Api
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

			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "BeABaApi", Version = "v1" });
			});

			services.AddDbContext<BebeaBaContext>(opt =>
			{
				opt.UseSqlServer(Configuration.GetConnectionString("Connection"), sqlServerOptionsAction: sqlOptions =>
				{
					sqlOptions.EnableRetryOnFailure();
					sqlOptions.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds);
					sqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
				}).EnableSensitiveDataLogging();
			});
		}



		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
			}
			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
