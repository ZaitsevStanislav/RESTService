using Microsoft.Extensions.DependencyInjection;
using RESTService.DataAccess.DatabaseContexts;
using RESTService.DataAccess.Repository;

namespace RESTService.DataAccess.Extensions
{
    public static class DatabaseExtentions
    {
        public static void AddUsersContext(this IServiceCollection services)
        {
            services.AddTransient<UsersDatabaseContext>();
            services.AddTransient<IUsersRepository, UsersRepository>();
        }
    }
}
