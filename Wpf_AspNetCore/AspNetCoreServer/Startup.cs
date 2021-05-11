using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;
using Microsoft.Extensions.Hosting;
using VenturaSQL;
using VenturaSQL.AspNetCore.Server.RequestHandling;
using Microsoft.OpenApi.Models;

namespace AspNetCoreServer
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers(options =>
            {
                options.InputFormatters.Insert(0, new FrameStreamInputFormatter()); // This enables the VenturaSQLController to receive a byte[] as parameter.

            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AspNetCoreServer", Version = "v1" });
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            string connection_string = "Server=tcp:sysdev-sqlserver-public.database.windows.net,1433;Initial Catalog=AdventureWorks2017;Persist Security Info=False;User ID=reader;Password=easypassword9!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            VenturaSqlConfig.DefaultConnector = new AdoConnector(SqlClientFactory.Instance, connection_string);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AspNetCoreServer v1"));
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

        }

    }
}
