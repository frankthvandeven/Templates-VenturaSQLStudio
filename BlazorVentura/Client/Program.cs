using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using VenturaSQL;

namespace BlazorVentura.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            VenturaSqlConfig.DefaultConnector = new HttpConnector("DefaultConnector", "api/venturasql");

            var host = builder.Build();

            /// VenturaSQL requests HttpClient instances from Blazor WebAssembly.
            VenturaSqlConfig.SetHttpClientFactory(connector => host.Services.GetService(typeof(HttpClient)) as HttpClient);

            await host.RunAsync();
        }

    }
}
