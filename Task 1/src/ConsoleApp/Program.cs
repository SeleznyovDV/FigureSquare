using ConsoleApp;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddMyServices();
var serviceProvider = services.BuildServiceProvider();

var calculation =  serviceProvider.GetRequiredService<Calculation>();

for (int i = 0; i < 10; i++)
{
    calculation.MakeCalculation();
}