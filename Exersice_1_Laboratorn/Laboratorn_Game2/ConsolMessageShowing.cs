
using Laboratorn_Game_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorn_Game2;

namespace Laboratorn_Game2
{
    /// <summary>
    /// Класс, выводящий строку на консоль
    /// </summary>
    class ConsolMessageShowing : IPrint
    {
        /// <summary>
        /// Метод, который выводит собщение(строку) на консоль
        /// </summary>
        /// <param name="st">Сообщение, строка</param>
        public void Print(string st)
        {
            Console.WriteLine(st + "\n");
        }
    }
}
