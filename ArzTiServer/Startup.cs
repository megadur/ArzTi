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
using ArzTiServer.OpenAPIService;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using ArzTiServer.Security;
using Microsoft.AspNetCore.Authentication;
using ArzTiServer.Filters;
using System.IO;
using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace ArzTiServer
{
    public class Startup
    {
        private readonly ILogger<Startup> _logger;
        
        private readonly IWebHostEnvironment _hostingEnv;

        public Startup(ILogger<Startup> logger, IWebHostEnvironment env, IConfiguration configuration)
        {
            _logger = logger;
            _hostingEnv = env;

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            _logger.LogInformation($"{nameof(ConfigureServices)} starting...");

            services.AddControllers();
            services.AddMvc(options =>
            {
                options.InputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>();
                options.OutputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter>();
            })
            .AddNewtonsoftJson(opts =>
            {
                opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                opts.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
            })
            .AddXmlSerializerFormatters();
            services.AddAuthentication(BasicAuthenticationHandler.SchemeName).AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(BasicAuthenticationHandler.SchemeName, null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "ArzTiServer", 
                    Version = "v1" ,
                    Description = "Webservice ArzTI API (ASP.NET Core 5.0)",
                    Contact = new OpenApiContact()
                    {
                        Name = "Swagger Codegen Contributors",
                        Url = new Uri("https://github.com/swagger-api/swagger-codegen"),
                        Email = ""
                    },
                    TermsOfService = new Uri("http://localhost")
                });
                c.CustomSchemaIds(type => type.FullName);
                c.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{_hostingEnv.ApplicationName}.xml");
                //c.TagActionsBy(p => p.HttpMethod); //Group and order by httpMethod.

                c.DocInclusionPredicate((name, api) => true);
                c.DocumentFilter<BasePathFilter>("/v1");
                // Include DataAnnotation attributes on Controller Action parameters as Swagger validation rules (e.g required, pattern, ..)
                // Use [ValidateModelState] on Actions to actually validate it in C# as well!
                c.OperationFilter<GeneratePathParamsValidationFilter>();
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

            services.AddScoped<IController, ArzTiController>();
            services.AddScoped<IArzTiDatenService, ArzTiDatenService>();
            services.AddScoped<IArzTiVerwaltungService, ArzTiVerwaltungService>();
            services.AddScoped<IDatenERepository, DatenERepository>();
            services.AddScoped<IVerwaltungRepository, VerwaltungRepository>();
            services.AddScoped<IAsyncRepository<ErApotheke>, ErApothekeRepository<ErApotheke>>();


            //var sqlConnectionString = Configuration["PostgreSqlConnectionString"];
            //services.AddDbContext<ArzDBContext>(options => options.UseNpgsql(Configuration["PostgreSqlConnectionString"]));
            services.AddDbContext<ArzDBContext>(options => options.UseNpgsql(Configuration["OpiPcConnectionString"]));
            //services.AddDbContext<ArzDBContext>(options => options.UseSqlite("Filename=TestDatabase.db"));

            _logger.LogInformation($"{nameof(ConfigureServices)} complete...");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder builder, IWebHostEnvironment env)
        {
            var logger = builder.ApplicationServices.GetService<ILogger<Startup>>();

            logger.LogInformation($"{nameof(Configure)} starting...");

            builder.UseRouting();

            builder.UseAuthorization();

  
            builder.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if (env.IsDevelopment())
            {
                builder.UseDeveloperExceptionPage();
                builder.UseSwagger();
                builder.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArzTiServer v1"));

            }
            else
            {
                //TODO: Enable production exception handling (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling)
                builder.UseExceptionHandler("/Error");

                builder.UseHsts();
            }

            //app.UseHttpsRedirection();

            /*
            builder.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            */
        }

        /*void fillDb()
        {
            string dbName = "TestDatabase.db";
            if (File.Exists(dbName))
            {
                File.Delete(dbName);
            }
            using (var dbContext = new    ArzDBContext())
            {
                //Ensure database is created
                dbContext.Database.EnsureCreated();
                if (!dbContext.ErApotheke.Any())
                {
                    dbContext.ErApotheke.AddRange(new ErApotheke[]
                        {
                             new ErApotheke{ ApoIkNr =1L, ApothekeName="A1" },
                             new ErApotheke{ ApoIkNr =2L, ApothekeName="A2" },
                             new ErApotheke{ ApoIkNr =2L, ApothekeName="A3" }
                        });
                    dbContext.SaveChanges();
                }
                foreach (var blog in dbContext.ErApotheke)
                {
                    Console.WriteLine($"BlogID={blog.BlogId}\tTitle={blog.Title}\t{blog.SubTitle}\tDateTimeAdd={blog.DateTimeAdd}");
                }
            }
            Console.ReadLine();
        }
    }
        */
    }
}
