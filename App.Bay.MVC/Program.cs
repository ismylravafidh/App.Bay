using App.Bay.Business;
using App.Bay.Business.Mapper;
using App.Bay.Business.ViewModels.FeatureVm;
using App.Bay.DAL.Common;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System;
using App.Bay.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation(opt =>
{
    opt.RegisterValidatorsFromAssembly(typeof(FeatureCreateVm).Assembly);
    opt.RegisterValidatorsFromAssembly(typeof(FeatureUpdateVm).Assembly);
}); ;

builder.Services.AddAutoMapper(typeof(MapperProfiles).Assembly);
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddServices();
builder.Services.AddRepositories();
var app = builder.Build();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.UseStaticFiles();


app.Run();
