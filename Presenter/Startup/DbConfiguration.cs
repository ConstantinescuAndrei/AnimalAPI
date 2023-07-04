using Data;
using Microsoft.EntityFrameworkCore;

namespace Presenter.Startup;

public static class DbConfiguration
{
    public static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        return services
            .AddDbContext<Context>(options => options.UseSqlite("Data Source=../Data/animals.db"),
                ServiceLifetime.Transient);
    }

    public static IApplicationBuilder ApplyDbMigrations(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()!.CreateScope();

        var context = serviceScope.ServiceProvider.GetRequiredService<Context>();
        context.Database.Migrate();
        
        return app;
    }
}