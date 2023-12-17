var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DempApp2.Model.SiteDbContext>();

builder.Services.AddRazorPages();
builder.Services.AddAuthentication()
    .AddCookie(option => option.LoginPath = "/Index");

var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();

app.Run();
