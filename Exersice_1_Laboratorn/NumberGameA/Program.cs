using Microsoft.Extensions.DependencyInjection; //Подключаем библиотеку для работы с DI. Внедрения зависимостей в .NET
namespace NumberGameA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var services = new ServiceCollection();

            services.AddSingleton<IPrinting, ConsolePrint>();

            services.AddSingleton<IEnter, ConsoleEnter>();

            services.AddSingleton<IEnter, ConsoleEnter>(provider =>
            {
                var print = provider.GetRequiredService<IPrinting>();
                return new ConsoleEnter(print);
            });

            services.AddTransient<IRandomGenerate>(provider =>
            {
                var enter = provider.GetRequiredService<IEnter>();
                var level = enter.MakeLevelChoose();
                int maximumnu = (level == Level.Easy) ? 10 : (level == Level.Medium) ? 100 : 1000;
                return new RandomGeneration(maximumnu);

            });

            services.AddTransient<NumberGame1>();

            var serviceProvider = services.BuildServiceProvider();

            var numberGameA = serviceProvider.GetRequiredService<NumberGame1>();

            numberGameA.Start();
        }
    }
}
