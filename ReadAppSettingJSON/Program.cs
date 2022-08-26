using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

//Read from App settings

var config1 = builder.Configuration["DefaultLevel:Error"];
Debug.WriteLine("Error", config1);
var config2 = builder.Configuration["DefaultLevel:Debug"];
Debug.WriteLine("Debug", config2);
var config3 = builder.Configuration["DefaultLevel:Warning"];
Debug.WriteLine("Warning", config3);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
