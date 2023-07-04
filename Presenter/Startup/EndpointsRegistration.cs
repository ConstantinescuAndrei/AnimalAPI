using Business.Login;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Presenter.Startup;

public static class EndpointsRegistration
{
    public static IApplicationBuilder UseEndpoints(this IApplicationBuilder app)
        => app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", () => "Get");
        });
}