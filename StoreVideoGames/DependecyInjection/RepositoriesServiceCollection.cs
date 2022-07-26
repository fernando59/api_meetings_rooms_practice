using StoreVideoGames.Manager.AssistantM;
using StoreVideoGames.Manager.EmployeeM;
using StoreVideoGames.Manager.ReservationM;
using StoreVideoGames.Manager.RoomM;
using StoreVideoGames.Manager.TitleM;
using StoreVideoGames.Repositories;
using StoreVideoGames.Repositories.AssistantRepository;
using StoreVideoGames.Repositories.EmployeeRepository;
using StoreVideoGames.Repositories.ReservationRepository;
using StoreVideoGames.Repositories.RoomRespository;

namespace StoreVideoGames.DependecyInjection
{
    public static class RepositoriesServiceCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) =>
            services.AddScoped<IRoomRepository, RoomRepository>()
                    .AddScoped<IEmployeeRepository, EmployeeRepository>()
                    .AddScoped<IReservationRepository, ReservationRepository>()
                    .AddScoped<IAssistantRepository, AssistantRepository>()
                    //Managers
                    .AddScoped<IRoomManager, RoomManager>()
                    .AddScoped<IEmployeeManager, EmployeeManager>()
                    .AddScoped<IReservationManager, ReservationManager>()
                    .AddScoped<IAssistantManager, AssistantManager>();

    }
}
