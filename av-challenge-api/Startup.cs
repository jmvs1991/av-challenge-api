using Connection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using av_challenge_api.Usuario.Services;

namespace av_challenge_api
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_ChallengeCors";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string conexion = Configuration.GetConnectionString("av_challenge").ToString() ?? "";
            //services.AddDbContext<ApiContext>(opt => opt.UseSqlServer(conexion));
            services.AddDbContext<ApiContext>(opt => opt.UseSqlServer(conexion, x => x.MigrationsAssembly("av-challenge-api")));

            services.AddControllers();
            //services.AddSingleton<>();
            AddCors(services);
            AddSwagger(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "av_challenge_api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"AV Challenge {groupName}",
                    Version = groupName,
                    Description = "Challenge Api",
                    Contact = new OpenApiContact
                    {
                        Name = "Jose V�squez",
                        Email = "josevasquez.dev@gmail.com",
                        Url = new Uri("https://jmvsportafolioreact.web.app/")
                    }
                });
            });
        }

        private void AddCors(IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
                                             .AllowAnyHeader()
                                             .AllowAnyMethod();
                                  });
            });

        }

    }
}
