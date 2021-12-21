using Blazored.Modal;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
             CreateHostBuilder(args).Build().Run();


            //var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //builder.RootComponents.Add<App>("#app");

            //builder.Services.AddHttpClient("WebAPI",
            //    client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            //    //.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            //// Supply HttpClient instances that include access tokens when making requests to the server project
            //builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebAPI"));

            ////builder.Services.AddApiAuthorization()
            ////    .AddAccountClaimsPrincipalFactory<RolesClaimsPrincipalFactory>();
            //builder.Services.AddBlazoredModal();
            //builder.Services.AddBlazoredSessionStorage();

            //builder.Services.AddLocalization();

            //await builder.Build().RunAsync();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
