using ArzTiServer.Controllers;
using ArzTiServer.Models;
using ArzTiServer.Repositories;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ArzTiServer.ArzTiService;

namespace ArzTiServer
{
    public class Startup
    {
        private readonly ILogger<Startup> _logger;

        public Startup(ILogger<Startup> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _logger.LogInformation($"{nameof(ConfigureServices)} starting...");

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ArzTiServer", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                        {
                              new OpenApiSecurityScheme
                                {
                                    Reference = new OpenApiReference
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "basic"
                                    }
                                },
                                new string[] {}
                        }
                        });
            });

            var sqlConnectionString = Configuration["PostgreSqlConnectionString"];
            services.AddScoped<IArzTiController, ArzTiController>();
            services.AddScoped<IArzTiDatenService, ArzTiDatenService>();
            services.AddScoped<IArzTiVerwaltungService, ArzTiVerwaltungService>();
            services.AddScoped<IDatenRepository, DatenRepository>();
            //services.AddScoped<IAsyncRepository<ErApotheke>, ErApothekeRepository<ErApotheke>>();
            

            services.AddDbContext<ArzDBContext>(options => options.UseNpgsql(Configuration["ApoDatenConnectionString"]));
            services.AddDbContext<ArzDBContext>(options => options.UseNpgsql(Configuration["ApoVerwaltungConnectionString"]));

            _logger.LogInformation($"{nameof(ConfigureServices)} complete...");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder builder, IWebHostEnvironment env)
        {
            var logger = builder.ApplicationServices.GetService<ILogger<Startup>>();

            logger.LogInformation($"{nameof(Configure)} starting...");


            if (env.IsDevelopment())
            {
                builder.UseDeveloperExceptionPage();
                builder.UseSwagger();
                builder.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArzTiServer v1"));

            }

            //app.UseHttpsRedirection();

            builder.UseRouting();

            builder.UseAuthorization();

            builder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
