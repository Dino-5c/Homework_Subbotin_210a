using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NumberGameA
{
    public class ConsoleEnter : IEnter
    {
        private readonly IPrinting Printing;

        public ConsoleEnter(IPrinting printing)
        {
            this.Printing = printing;
        }

        public int UserNumberEntering()
        {
            Printing.Print("Ввод числа: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка, попробуйте ввести число ещё раз");
            }
            return number;
        }

        public Level MakeLevelChoose()
        {
            Printing.Print("Выберите уровень сложности: 1 - Лёгкий, 2 - Средний, 3 - Сложный");
            int choose;
            while(!int.TryParse(Console.ReadLine(), out choose) || choose < 1 && choose > 3)
            {
                Printing.Print("Ошибка, введите число в диапазоне [1;3]");
            }
            return
                (choose == 1) ? Level.Easy
                : (choose == 2) ? Level.Medium : Level.Hard;
        }
    }
}
