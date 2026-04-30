using TestMenu.Client.Pages;
using TestMenu.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestMenu.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TestMenuContextDB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TestMenuContextDB") ?? throw new InvalidOperationException("Connection string 'TestMenuContextDB' not found.")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(TestMenu.Client._Imports).Assembly);

app.Run();
