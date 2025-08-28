
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorn_Game2;

namespace Laboratorn_Game_2
{
    /// <summary>
    /// Класс для проверки введённого значения, выбирающего какую часть программы нужно выполнить 
    /// </summary>
    class DoChooseValidator
    {
        /// <summary>
        /// Метод, проверяющий введённое значение для выбора выполнения части программы
        /// </summary>
        /// <param name="tmp">Значение</param>
        /// <returns>Значение</returns>
        public static int Validation(int tmp)
        {

            while (!int.TryParse(Console.ReadLine(), out tmp) || tmp < /*1 */ 2 || tmp > 5)
            {
                Messag.Printing(new ConsolMessageShowing(), "Error! Input another number in [1;5].");
            }
            return tmp;
        }

    }
}
