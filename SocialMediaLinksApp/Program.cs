using SocialMediaLinksApp.Models.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); 
builder.Services.Configure<SocialMediaLinks>(
    builder.Configuration.GetSection("SocialMediaLinks")
    );
var app = builder.Build();
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();

app.Run();
