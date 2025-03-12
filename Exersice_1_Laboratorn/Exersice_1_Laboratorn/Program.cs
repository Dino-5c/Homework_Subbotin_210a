
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {




            var tanks = GetTanks();
            var units = GetUnits();
            var factories = GetFactories();
            Console.WriteLine($"Количество резервуаров: {tanks.Length}, установок: {units.Length}");

            var foundUnit = FindUnit(units, tanks, "Резервуар 2");
            var factory = FindFactory(factories, foundUnit);

            Console.WriteLine($"Резервуар 2 принадлежит установке {foundUnit.Name} и заводу {factory.Name}");

            var totalVolume = GetTotalVolume(tanks);
            Console.WriteLine($"Общий объем резервуаров: {totalVolume}");


            int select;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите одну из задач: \n 1.Произвести Поиск по наименованию в коллекции. \n 2. Вывести всю информацию. \n 3. Вывести информацию о резервуаре, включая имена цеха и фабрики. \n 4. Вычислить сумму загрузки резервуаров. \n или 0 для завершения");
                while (!int.TryParse(Console.ReadLine(), out select))
                {
                    Console.WriteLine("ошибка, попробуйте опять");
                }
                Console.WriteLine();
                switch (select)
                {
                    case 1: NameSearching(factories, units, tanks); break;
                    case 2: PrintAll(tanks, units, factories); break;
                    case 3: SearchingInfoAboutTank(tanks, units, factories); break;
                    case 4:
                        GetTotalVolume(tanks);
                        var totalVlme = GetTotalVolume(tanks);
                        Console.WriteLine($"Общий объем резервуаров: {totalVlme}");
                        Console.WriteLine();
                        break;
                    default: flag = false; break;
                }
            }


        }

        // реализуйте этот метод, чтобы он возвращал массив резервуаров, согласно приложенным таблицам
        // можно использовать создание объектов прямо в C# коде через new, или читать из файла (на своё усмотрение)
        public static Tank[] GetTanks()
        {
            // ваш код здесь
            // Создание объектов класса Tank (Резервуар)
            Tank tank1 = new Tank(new Guid("AAAAAAA1-BBBB-CCCC-DDDD-3EEEEEEEEEEE"), "Резервуар 1", "Надземный-вертикальный", 1500, 2000, Guid.Parse("AAAAAAA1-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));
            Tank tank2 = new Tank(new Guid("AAAAAAA2-BBBB-CCCC-DDDD-3EEEEEEEEEEE"), "Резервуар 2", "Надземный-горизонтальный", 2500, 3000, Guid.Parse("AAAAAAA1-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));
            Tank tank3 = new Tank(new Guid("AAAAAAA3-BBBB-CCCC-DDDD-3EEEEEEEEEEE"), "Дополнительный резервуар 24", "Надземный-горизонтальный", 3000, 3000, Guid.Parse("AAAAAAA2-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));
            Tank tank4 = new Tank(new Guid("AAAAAAA4-BBBB-CCCC-DDDD-3EEEEEEEEEEE"), "Резервуар 35", "Надземный-вертикальный", 3000, 3000, Guid.Parse("AAAAAAA2-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));
            Tank tank5 = new Tank(new Guid("AAAAAAA5-BBBB-CCCC-DDDD-3EEEEEEEEEEE"), "Резервуар 47", "Надземный-двустенный", 4000, 5000, Guid.Parse("AAAAAAA2-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));
            Tank tank6 = new Tank(new Guid("AAAAAAA6-BBBB-CCCC-DDDD-3EEEEEEEEEEE"), "Резервуар 256", "Подводный", 500, 500, Guid.Parse("AAAAAAA3-BBBB-CCCC-DDDD-2EEEEEEEEEEE"));

            Tank[] tank_ar = { tank1, tank2, tank3, tank4, tank5, tank6 };
            return tank_ar;
        }
        // реализуйте этот метод, чтобы он возвращал массив установок, согласно приложенным таблицам
        public static Unit[] GetUnits()
        {
            // TryParse для Guid
            /* if (Guid.TryParse(stringGuid, out var newGuid))
                   Console.WriteLine($"Converted {stringGuid} to a Guid"); */

            // ваш код здесь
            // Создание объектов класса Unit (Установка)
            Unit unit1 = new Unit(new Guid("AAAAAAA1-BBBB-CCCC-DDDD-2EEEEEEEEEEE"), "ГФУ-2", "Газофракцинирующая установка", Guid.Parse("AAAAAAA1-BBBB-CCCC-DDDD-1EEEEEEEEEEE"));
            Unit unit2 = new Unit(new Guid("AAAAAAA2-BBBB-CCCC-DDDD-2EEEEEEEEEEE"), "АВТ-6", "Атмосферно-вакуумная трубчатка", Guid.Parse("AAAAAAA1-BBBB-CCCC-DDDD-1EEEEEEEEEEE"));
            Unit unit3 = new Unit(new Guid("AAAAAAA3-BBBB-CCCC-DDDD-2EEEEEEEEEEE"), "АВТ-10", "Атосферно-вакуумная трубчатка", Guid.Parse("AAAAAAA2-BBBB-CCCC-DDDD-1EEEEEEEEEEE"));

            Unit[] unit = { unit1, unit2, unit3 };
            return unit;
        }
        // реализуйте этот метод, чтобы он возвращал массив заводов, согласно приложенным таблицам
        public static Factory[] GetFactories()
        {
            // ваш код здесь

            // Создание объектов класса Factory (Завод)
            Factory factory1 = new Factory(new Guid("AAAAAAA1-BBBB-CCCC-DDDD-1EEEEEEEEEEE"), "НПЗ№1", "Первый нефтеперерабатывающий завод");
            Factory factory2 = new Factory(new Guid("AAAAAAA2-BBBB-CCCC-DDDD-1EEEEEEEEEEE"), "НПЗ№2", "Второй нефтеперерабатывающий завод");
            Factory[] arr = { factory1, factory2 };
            return arr;
        }

        // реализуйте этот метод, чтобы он возвращал установку (Unit), которой
        // принадлежит резервуар (Tank), найденный в массиве резервуаров по имени
        // учтите, что по заданному имени может быть не найден резервуар
        public static Unit FindUnit(Unit[] units, Tank[] tanks, string unitName)
        {
            int count = 0;
            // ваш код здесь
            for (int i = 0; i < tanks.Length; i++)
            {
                if (tanks[i].Name == unitName)
                {
                    for (int j = 0; j < units.Length; j++)
                    {
                        if (tanks[i].UnitId == units[j].Id)
                        {
                            return units[j];
                        }
                    }
                }

            }
            if (count == 0)
                Console.WriteLine("Значение не удалось обнаружить");
            // throw new Exception("Не удалось найти значение");
            Unit unit = new Unit(new Guid("AAAAAAA0-BBBB-CCCC-DDDD-2EEEEEEEEEEE"), "no", "--", Guid.Parse("AAAAAAA0-BBBB-CCCC-DDDD-1EEEEEEEEEEE"));
            return unit;
        }

        // реализуйте этот метод, чтобы он возвращал объект завода, соответствующий установке
        public static Factory FindFactory(Factory[] factories, Unit unit)
        {
            if (factories == null)
            {
                Console.WriteLine("Переданный Массив пуст");
                throw new Exception("Пустой массив передан в данный метод.");
            }
            int count = 0;
            // ваш код здесь
            for (int i = 0; i < factories.Length; i++)
            {
                if (unit.FactoryId == factories[i].Id)
                {
                    count++;
                    return factories[i];
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Не найдено значений");
                // throw new Exception("Не найдено нужное значение");

            }
            Factory factory = new Factory(new Guid("AAAAAAA0-BBBB-CCCC-DDDD-1EEEEEEEEEEE"), "no", "--");
            return factory;


        }

        // реализуйте этот метод, чтобы он возвращал суммарный объем резервуаров в массиве
        public static int GetTotalVolume(Tank[] tanks)
        {
            if (tanks == null)
            {
                Console.WriteLine("Переданный Массив пуст");
                throw new Exception("Пустой массив передан в данный метод.");
            }
            int sum = 0;
            // ваш код здесь
            for (int i = 0; i < tanks.Length; i++)
            {
                sum += tanks[i].Volume;
            }
            return sum;
        }



        /// <summary>
        /// Метод, в котором можно выбрать, какой объект по имени вы хотите отыскать
        /// </summary>
        /// <param name="factories">Массив Заводов</param>
        /// <param name="units">Массив Установок</param>
        /// <param name="tanks">Массив Резервуаров</param>
        /// <exception cref="Exception">Исключение, срабатывающее, если какой-то из массивов пуст</exception>
        public static void NameSearching(Factory[] factories, Unit[] units, Tank[] tanks)
        {
            if (factories == null || units == null || tanks == null)
            {
                Console.WriteLine("Переданный Массив пуст");
                throw new Exception("Пустой массив передан в данный метод.");
            }
            Console.WriteLine("Поиск по введённому имени");
            int select;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Какой вы хотите Произвести Поиск по наименованию в коллекции. \n 1. По наименованию Резервуара \n 2. По наименованию Установки \n 3. По наименованию Завода  \n или нажмите 0 для завершения");
                Console.WriteLine();
                while (!int.TryParse(Console.ReadLine(), out select))
                {
                    Console.WriteLine("ошибка, попробуйте опять");
                }
                switch (select)
                {
                    case 1: TankNameSearching(tanks); break;
                    case 2: UnitNameSearching(units); break;
                    case 3: FactoryNameSearching(factories); break;
                    default: flag = false; break;
                }
            }

        }

        /// <summary>
        /// Вспомогательный метод, который ищет Резервуар по названию
        /// </summary>
        /// <param name="tanks">Массив Резеруаров</param>
        public static void TankNameSearching(Tank[] tanks)
        {
            string name;
            Console.WriteLine("Введите название");
            name = Console.ReadLine();
            Console.WriteLine();
            if (tanks == null)
            {
                Console.WriteLine("Не найдено значений в массиве");
                return;
            }
            int count = 0;
            for (int i = 0; i < tanks.Length; i++)
            {
                if (name == tanks[i].Name)
                {
                    count++;
                    tanks[i].Printing();
                    Console.WriteLine();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Не найдено значений в массиве");
            }
        }

        /// <summary>
        /// Вспомогательный метод, который ищет Установку по названию
        /// </summary>
        /// <param name="units">Массив Установок</param>
        public static void UnitNameSearching(Unit[] units)
        {
            string name;
            Console.WriteLine("Введите название");
            name = Console.ReadLine();
            Console.WriteLine();
            if (units == null)
            {
                Console.WriteLine("Не найдено значений в массиве");
                Console.WriteLine();
                return;
            }
            int count = 0;
            for (int i = 0; i < units.Length; i++)
            {
                if (name == units[i].Name)
                {
                    count++;
                    units[i].Printing();
                    Console.WriteLine();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Не найдено значений в массиве");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вспомогательный метод, который ищет Завод по названию
        /// </summary>
        /// <param name="factories">Массив заводов</param>
        public static void FactoryNameSearching(Factory[] factories)
        {
            string name;
            Console.WriteLine("Введите название");
            name = Console.ReadLine();
            Console.WriteLine();
            if (factories == null)
            {
                Console.WriteLine("Не найдено значений в массиве");
                return;
            }
            int count = 0;
            for (int i = 0; i < factories.Length; i++)
            {
                if (name == factories[i].Name)
                {
                    count++;
                    factories[i].Printing();
                    Console.WriteLine();
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Не найдено значений в массиве");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод, печатающий на экран Всю информацию о каждой установке, каждом резервуаре, каждом заводе
        /// </summary>
        /// <param name="tanks">Массив резервуаров</param>
        /// <param name="units">Массив установок</param>
        /// <param name="factories">Массив заводов</param>
        public static void PrintAll(Tank[] tanks, Unit[] units, Factory[] factories)
        {
            if (factories == null || units == null || tanks == null)
            {
                Console.WriteLine("Какой-либо из Переданных Массивов пуст");
                return;
            }
            PrintAllTanks(tanks);
            PrintAllUnits(units);
            PrintAllFactories(factories);
        }

        /// <summary>
        /// Вспомогательный метод, выводящий на экран массив резервуаров
        /// </summary>
        /// <param name="tanks">Массив резервуаров</param>
        public static void PrintAllTanks(Tank[] tanks)
        {
            if (tanks == null)
            {
                Console.WriteLine("Массив пуст");
                return;
            }
            Console.WriteLine("Резервуары");
            for (int i = 0; i < tanks.Length; i++)
            {
                tanks[i].Printing();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вспомогательный метод, выводящий на экран массив установок
        /// </summary>
        /// <param name="units">Массив установок</param>
        public static void PrintAllUnits(Unit[] units)
        {
            if (units == null)
            {
                Console.WriteLine("Массив пуст");
                return;
            }
            Console.WriteLine("Установки");
            for (int i = 0; i < units.Length; i++)
            {
                units[i].Printing();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вспомогательный метод, выводящий на экран массив заводов
        /// </summary>
        /// <param name="factories">Массив заводов</param>
        public static void PrintAllFactories(Factory[] factories)
        {
            if (factories == null)
            {
                Console.WriteLine("Массив пуст");
                return;
            }
            Console.WriteLine("Заводы");
            for (int i = 0; i < factories.Length; i++)
            {
                factories[i].Printing();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод, который ищет информацию о резервуаре и название установки, на которой он находится, и название завода, на котором находится установка
        /// </summary>
        /// <param name="tanks">Массив резервуаров</param>
        /// <param name="units">Массив установок</param>
        /// <param name="factories">Массив заводов</param>
        public static void SearchingInfoAboutTank(Tank[] tanks, Unit[] units, Factory[] factories)
        {
            if (factories == null || units == null || tanks == null)
            {
                Console.WriteLine("Переданный Массив пуст");
                return;
            }
            int count = 0;
            string name;
            Console.WriteLine("Введите название");
            name = Console.ReadLine();

            for (int i = 0; i < tanks.Length; i++)
            {
                if (name == tanks[i].Name)
                {
                    for (int j = 0; j < units.Length; j++)
                    {
                        if (tanks[i].UnitId == units[j].Id)
                        {
                            for (int k = 0; k < factories.Length; k++)
                            {
                                if (units[j].FactoryId == factories[k].Id)
                                {
                                    count++;
                                    Console.WriteLine($"Id: {tanks[i].Id}, Name: {tanks[i].Name}, Description: {tanks[i].Description}, Volume: {tanks[i].Volume}, Max Volume: {tanks[i].MaxVolume}, Unit Name: {units[k].Name}, Factory Name: {factories[k].Name}");
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Не найдено значений");
                return;
            }
        }

    }

}
