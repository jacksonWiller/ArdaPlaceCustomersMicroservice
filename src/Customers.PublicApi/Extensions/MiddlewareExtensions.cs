using Microsoft.AspNetCore.Builder;
using Customers.PublicApi.Middlewares;

namespace Customers.PublicApi.Extensions;

internal static class MiddlewareExtensions
{
    public static void UseCorrelationId(this IApplicationBuilder builder) =>
        builder.UseMiddleware<CorrelationIdMiddleware>();

    public static void UseErrorHandling(this IApplicationBuilder builder) =>
        builder.UseMiddleware<ErrorHandlingMiddleware>();
}