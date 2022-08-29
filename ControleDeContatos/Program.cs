using ControleDeContatos.Data;
using ControleDeContatos.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BancoContext>(opt => opt.UseSqlServer("Data Source=DESKTOP-ICHE76Q\\SQLSERVER;Initial Catalog=DB_SistemaContatos;Integrated Security=True"));
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();//Toda vez que a I contatoRepository for chamada eu quero que ela resolva com ContatoRepository
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
