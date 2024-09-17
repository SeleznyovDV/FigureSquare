namespace ConsoleApp
{
    using FigureSquare.Abstractions;
    using FigureSquare.Implementations;
    using Microsoft.Extensions.DependencyInjection;

    internal static class DependencyInjection
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<IFigureFactory, FigureFactory>();
            services.AddSingleton<ISquareCalculator, SquareCalculator>();
            services.AddTransient<Calculation, Calculation>();
            return services;
        }
    }
}
