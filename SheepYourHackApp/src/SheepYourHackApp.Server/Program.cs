using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NextjsStaticHosting.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Step 1: Add Next.js hosting support
builder.Services.Configure<SheepYourHackHostingOptions>(builder.Configuration.GetSection("NextjsStaticHosting"));
builder.Services.AddNextjsStaticHosting();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseSwagger();
app.UseSwaggerUI();

app.MapNextjsStaticHtmls();
app.UseNextjsStaticHosting();

app.Run();
