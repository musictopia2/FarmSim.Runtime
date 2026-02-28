namespace FarmSim.Runtime;
public static class ServiceExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddFarmSimRuntime()
        {
            services.AddSingleton<IGameTickRunner, GameTickRunner>()
                .AddSingleton<GameRegistry>()
                .AddSingleton<FarmTransferService>()
                .AddSingleton<StartingOptionsCoordinatorService>()
                .AddSingleton<InventoryStorageStartingOptionsService>()
                .AddSingleton<AdvancedSettingsStartingOptionsService>()
                .AddSingleton<TreeStartingOptionsService>()
                .AddSingleton<CropStartingOptionsService>()
                .AddSingleton<AnimalStartingOptionsService>()
                .AddSingleton<WorkshopStartingOptions>()
                .AddSingleton<WorksiteStartingOptions>()
                .AddSingleton<AchievementsStartingOptionsService>()
                .AddSingleton<GiftLedgerService>()
                ;
            return services;
        }
    }
}