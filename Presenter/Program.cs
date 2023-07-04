using Presenter.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers().Services
    .AddDatabase();

var app = builder.Build();

app.UseRouting()
    .UseEndpoints()
    .ApplyDbMigrations();

app.Run();