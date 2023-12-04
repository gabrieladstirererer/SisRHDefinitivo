
using SisRHDefinitivo.Core.Repository.Data;


var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<FuncionarioRepository, FuncionarioRepository>();
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<BancoContext>
//    (options => options.UserSqlServer(""));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/SisRh/Error"); // Home
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=SisRh}/{action=Index}/{id?}");

app.Run();
