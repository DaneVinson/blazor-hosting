using Blazor.Core.Shared;
using Blazor.Server.Host;
using Domain;
using Services.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IPlanetsApi, PlanetsDataService>();
builder.Services
        .AddRazorComponents()
        .AddInteractiveServerComponents();

var app = builder.Build();

app.UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(MainLayout).Assembly);

app.Run();
