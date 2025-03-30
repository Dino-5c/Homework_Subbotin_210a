using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Laboratorn_Game2;

namespace Laboratorn_Game_2
{
    /// <summary>
    /// Класс для вывода сообщения
    /// </summary>
    class Messag
    {
        /// <summary>
        /// Метод, который выводит сообщение в нужной форме
        /// </summary>
        /// <param name="printering">Формат вывода сообщения(консоль, форма и др.)</param>
        /// <param name="mess">Строка, текст</param>
        public static void Printing(IPrint printering, string mess)
        {
            printering.Print(mess);
        }
    }
}
