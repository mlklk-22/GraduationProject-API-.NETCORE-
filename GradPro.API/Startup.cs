using GradPro.CORE.Common;
using GradPro.CORE.Repository;
using GradPro.CORE.Service;
using GradPro.INFRA.Common;
using GradPro.INFRA.Repository;
using GradPro.INFRA.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradPro.API
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
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("policy",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

           /* services.AddAuthentication(opt => {
             //   opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               // opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options => {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"))
                };
            });*/
            services.AddControllers();

            services.AddScoped<IDbContext, DbContext>();

            // ----Services----
            services.AddScoped<IUserGradService, UserGradService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectUserService, ProjectUserService>();

            // ----Respositories----
            services.AddScoped<IUserGradRespoitory, UserGradRespoitory>();
            services.AddScoped<IProjectRespository, ProjectRespoitory>();
            services.AddScoped<IProjectUserRepository, ProjectUserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("policy");

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
