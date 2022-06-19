using Blazored.LocalStorage;
using Majorsoft.Blazor.Components.CssEvents;
using Majorsoft.Blazor.Components.Notifications;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using SocialMediaPlanner.Client;
using SocialMediaPlanner.Client.Brokers.API;
using SocialMediaPlanner.Client.Providers;
using SocialMediaPlanner.Client.Service.Authentication;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#wrapper");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IApiBroker, ApiBroker>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();


builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();


builder.Services.AddScoped<ApiAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(p =>
                p.GetRequiredService<ApiAuthenticationStateProvider>());

builder.Services.AddCssEvents();
builder.Services.AddNotifications();
builder.Services.AddLocalization();

var host = builder.Build();

var jsInterop = host.Services.GetRequiredService<IJSRuntime>();

var result = await jsInterop.InvokeAsync<string>("blazorCulture.get");
if (result != null)
{
    var culture = new CultureInfo(result);
    CultureInfo.DefaultThreadCurrentCulture = culture;
    CultureInfo.DefaultThreadCurrentUICulture = culture;
}

await host.RunAsync();
