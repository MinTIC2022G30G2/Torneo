using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using RazorPagesMovie.Data;
using Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Persistencia.AppContext>();
builder.Services.AddScoped<IRColegio,RColegio>();
builder.Services.AddScoped<IRDeportista,RDeportista>();
builder.Services.AddScoped<IREncuentro,REncuentro>();
builder.Services.AddScoped<IREntrenador,REntrenador>();
builder.Services.AddScoped<IREquipo,REquipo>();
builder.Services.AddScoped<IREscenario,REscenario>();
builder.Services.AddScoped<IRFixture,RFixture>();
builder.Services.AddScoped<IRJuez,RJuez>();
builder.Services.AddScoped<IRModalidad,RModalidad>();
builder.Services.AddScoped<IRMunicipio,RMunicipio>();
builder.Services.AddScoped<IRPatrocinador,RPatrocinador>();
builder.Services.AddScoped<IRTorneo,RTorneo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
