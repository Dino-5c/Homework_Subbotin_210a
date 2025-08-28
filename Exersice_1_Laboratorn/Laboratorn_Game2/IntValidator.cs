using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorn_Game2;

namespace Laboratorn_Game_2
{
    /// <summary>
    /// Класс, который проверяет числа
    /// </summary>
    class IntValidator
    {
        /// <summary>
        /// Метод, который проверяет числа
        /// </summary>
        /// <param name="numberr">Значение</param>
        /// <returns>Флаг, который показывает, истинно значение или ложно</returns>
        /// <exception cref="Exception">Исключение, которое происходит, если значение, введенное пользователем, может быть некорректным числом</exception>
        public static bool Validate(int numberr)
        {
            if (!int.TryParse(Console.ReadLine(), out numberr) || numberr < 0)
            {
                return false;
                throw new Exception("Error");

            }
            return true;
        }
    }
}
