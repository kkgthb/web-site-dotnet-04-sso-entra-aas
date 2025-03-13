using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Necessary for actually starting to route some API endpoints

builder.Configuration.Sources.Clear();
builder.Configuration
    .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true); // DEBUG SYNTAX ONLY
//Console.WriteLine(builder.Configuration.GetSection("Entra")["Instance"]); // DEBUG LINE ONLY

builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("Entra"));

var app = builder.Build();

app.MapControllers(); // Necessary for actually starting to route some API endpoints

app.Run();
