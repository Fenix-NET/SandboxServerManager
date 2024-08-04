namespace SandboxServerManager.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        // Здесь настройка политики CORS
        public static void ConfigurationCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

        // Настройки сервера IIS
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

    }
}
