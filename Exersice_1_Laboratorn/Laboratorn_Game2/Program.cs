using Laboratorn_Game_2;
using Laboratorn_Game2;
using System;

namespace Lesson2_110a
{
    class Program
    {

        /// <summary>
        /// Задача. Игра "угадай число"
        /// 1. Программа генерирует случайное число в [1;100]
        /// пользователь его угадывает.
        /// 2. Меню:    1. Изменить границы
        ///             2. Сыграть в игру
        ///             3. Вывести статистику (набольшее кол-во попыток, наименьшее ..., среднее)
        ///             4. Выход
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game.StartGame();
        }
    }
}

