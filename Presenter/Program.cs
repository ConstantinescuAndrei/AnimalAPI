using Presenter.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers().Services
    .AddDatabase()
    .AddBusiness();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy", policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("Policy");
app.UseRouting()
    .UseEndpoints()
    .ApplyDbMigrations();

app.Run();