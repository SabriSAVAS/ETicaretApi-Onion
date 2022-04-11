using ETicaretApi.Application.Abstractions;
using ETicaretApi.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
