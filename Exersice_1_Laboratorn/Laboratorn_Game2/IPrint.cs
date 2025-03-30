using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorn_Game2;

namespace Laboratorn_Game_2
{
    /// <summary>
    /// Интерфейс для вывода сообщения
    /// </summary>
    interface IPrint
    {
        /// <summary>
        /// Метод, который содержит метод, выводящий сообщение в нужном варианте
        /// </summary>
        /// <param name="st">Текст</param>
        void Print(string st);
    }
}
