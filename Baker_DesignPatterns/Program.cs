using Baker_DesignPatterns.CQRSPattern.Handlers.AboutHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.ContactHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.ProductHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.SubscribeHandlers;
using Baker_DesignPatterns.CQRSPattern.Handlers.TeamHandlers;
using Baker_DesignPatterns.DAL.Context;
using Baker_DesignPatterns.DAL.Entities;
using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BakerContext>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetProductQueryHandler>();
builder.Services.AddScoped<GetTeamQueryHandler>();
builder.Services.AddScoped<GetSubscribeQueryHandler>();
builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<CreateTeamCommandHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<GetProductByIdQueryHandler>();
builder.Services.AddScoped<GetTeamByIdQueryHandler>();
builder.Services.AddScoped<GetSubscribeByIdQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<UpdateProductCommandHandler>();
builder.Services.AddScoped<UpdateTeamCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
builder.Services.AddScoped<RemoveProductCommandHandler>();
builder.Services.AddScoped<RemoveTeamCommandHandler>();
builder.Services.AddScoped<RemoveSubscribeCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<BakerContext>();





// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
