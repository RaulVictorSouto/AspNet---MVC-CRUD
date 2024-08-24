using Microsoft.EntityFrameworkCore;
using WebMvCMySql.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//se algo der errado, adicionar  "Microsoft.EntityFrameworkCore." antes de ServerVersion 
builder.Services.AddDbContext<Contexto>
    (options => options.UseMySql(
        "server=localhost; initial catalog=CRUD_MVC; uid=root; pwd=''",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.36-mysql")));

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
    pattern: "{controller=Usuarios}/{action=Index}/{id?}");

app.Run();
