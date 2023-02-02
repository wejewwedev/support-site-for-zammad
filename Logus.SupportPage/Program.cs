using Logus.SupportPage.Infrastructure.Abstraction;
using Logus.SupportPage.Infrastructure.Abstraction.Implementation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<IHttpService, HttpService>();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<ZammadUserService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<CustomHttpContext>();
builder.Services.AddTransient<SecurePasswordHasher>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
