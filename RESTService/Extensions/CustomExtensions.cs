using Microsoft.Extensions.DependencyInjection;
using RESTService.Services;

namespace RESTService.Extensions
{
    public static class CustomExtensions{
        public static void AddUserService(this IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserService>();
        }
    }
}
