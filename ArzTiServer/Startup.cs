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
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using ArzTiServer.Security;
using Microsoft.AspNetCore.Authentication;
using ArzTiServer.Filters;
using System.IO;
using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Controllers;
using Serilog;
using ArzTiServer.Infrastructure.Middlewares;
using Serilog.Ui.Web;
using Serilog.Ui.PostgreSqlProvider.Extensions;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Http;

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
            services.AddSingleton<Serilog.ILogger>(Log.Logger);
            services.AddLogging();
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
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ArzTiServer",
                    Version = "v1",
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

            //services.AddScoped<ApothekeApiController, ApothekeApiImpl>();
            services.AddScoped<IArzTiDatenService, ArzTiDatenService>();
            services.AddScoped<IArzTiVerwaltungService, ArzTiVerwaltungService>();
            services.AddScoped<IDatenERepository, DatenERepository>();
            services.AddScoped<IVerwaltungRepository, VerwaltungRepository>();
            services.AddScoped<IAsyncRepository<ErApotheke>, ErApothekeRepository<ErApotheke>>();

            //var sqlConnectionString = Configuration["PostgreSqlConnectionString"];
            var sqlConnectionString = Configuration["OpiPcConnectionString"];
            //services.AddDbContext<ArzDBContext>(options => options.UseNpgsql(Configuration["PostgreSqlConnectionString"]));
            services.AddDbContext<ArzDBContext>(options => options.UseNpgsql(sqlConnectionString));
            //services.AddDbContext<ArzDBContext>(options => options.UseSqlite("Filename=TestDatabase.db"));
            //var connectionString = new ConnectionString(Configuration.GetConnectionString("DefaultConnection"));
            services.AddSerilogUi(options => options

                .EnableAuthorization(authOptions =>
                {
                    authOptions.AuthenticationType = AuthenticationType.Jwt; // or AuthenticationType.Cookie
                    authOptions.Usernames = new[] { "User1", "User2" };
                    authOptions.Roles = new[] { "AdminRole" };
                })

                .UseNpgSql(sqlConnectionString, "table_name")
            );

            //adding health check services to container
            services.AddHealthChecks().AddNpgSql(sqlConnectionString);
            //adding healthchecks UI
            services.AddHealthChecksUI(opt =>
            {
                opt.SetEvaluationTimeInSeconds(15); //time in seconds between check
                opt.MaximumHistoryEntriesPerEndpoint(60); //maximum history of checks
                opt.SetApiMaxActiveRequests(1); //api requests concurrency

                opt.AddHealthCheckEndpoint("default api", "/healthz"); //map health check api
            })
            .AddInMemoryStorage();

            _logger.LogInformation($"{nameof(ConfigureServices)} complete...");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var logger = app.ApplicationServices.GetService<ILogger<Startup>>();
            loggerFactory.AddSerilog();
            logger.LogInformation($"{nameof(Configure)} starting...");
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSerilogRequestLogging();

            app.UseMiddleware<ApiExceptionHandlingMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //adding endpoint of health check for the health check ui in UI format
                endpoints.MapHealthChecks("/healthz", new HealthCheckOptions
                {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });

                //map healthcheck ui endpoing - default is /healthchecks-ui/
                endpoints.MapHealthChecksUI();

                endpoints.MapGet("/", async context => await context.Response.WriteAsync("Hello World!"));
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                    {
                        // set route prefix to openapi, e.g. http://localhost:8080/openapi/index.html
                        //c.RoutePrefix = "openapi";
                        //TODO: Either use the SwaggerGen generated OpenAPI contract (generated from C# classes)
                        //c.SwaggerEndpoint("/openapi/1.0.0/openapi.json", "Swagger Petstore");
                        //TODO: Or alternatively use the original OpenAPI contract that's included in the static files
                        c.SwaggerEndpoint("/swagger-original.json", "ArzTiServer v1 Original");
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArzTiServer v1");
                        c.RoutePrefix = "swagger";
                    });

            }
            else
            {
                //TODO: Enable production exception handling (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling)
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }
            // Enable middleware to serve log-ui (HTML, JS, CSS, etc.).
            app.UseSerilogUi();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

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
