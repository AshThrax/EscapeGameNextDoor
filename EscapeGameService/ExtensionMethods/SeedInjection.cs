namespace EscapeGameService.ExtensionMethods;

    public static class SeedInjection
    {
        public async static Task<WebApplication> AddSeedDatabaseInjection(this WebApplication app) 
        {

                using (IServiceScope scope = app.Services.CreateScope())
                {
                    DataContext context = scope.ServiceProvider.GetRequiredService<DataContext>();

                    await context.Database.MigrateAsync();
                    await SeedData.SeedAsync(context);
                }

                return app;
        }
    }

