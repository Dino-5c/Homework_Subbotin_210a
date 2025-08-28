
using Laboratorn_Game2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Laboratorn_Game_2
{
    /// <summary>
    /// Класс для провепки введённого значения
    /// </summary>
    class NumberValidator
    {
        /// <summary>
        /// Метод, который проверяет переданное число на вхождение в какой-либо диапазон
        /// </summary>
        /// <param name="number">Число, которое проверяем</param>
        /// <returns>Валидированное Значение</returns>
        public static int NumberValidation(int number, int firstNum, int lastNum )
        {
            while (!int.TryParse(Console.ReadLine(), out number) || firstNum < 1 || number > lastNum)
            {
                Messag.Printing(new ConsolMessageShowing(), $"Error! Input another number. Number not in diapazon [{firstNum};{lastNum}]");
            }
            return number;
        }
    }
}
