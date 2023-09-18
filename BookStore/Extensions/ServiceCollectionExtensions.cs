using Books.Core.Data;

namespace Books.Manage.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddDbContext<BookDbContext>(options =>
        {
            
        });
        return services;
    }
}

