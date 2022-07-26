using StoreVideoGames.Manager.TitleM;
using StoreVideoGames.Repositories;
using StoreVideoGames.Repositories.TitleRepository;

namespace StoreVideoGames.DependecyInjection
{
    public static class RepositoriesServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services.AddScoped<ITitleRepository, TitleRepository>()
            .AddScoped<ITitleManager, TitleManager>();
    }
}
