using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    /// <summary>
    /// Класс проверки значения int
    /// </summary>
    class IntValidator
    {

        /// <summary>
        /// Метод проверки корректности переданного параметра
        /// </summary>
        /// <param name="value">Значение, которое проверяется</param>
        /// <returns>Флаг, правильно ли значение?</returns>
        static public bool Validate(int value)
        {
            return value > 0;
        }
    }
}
