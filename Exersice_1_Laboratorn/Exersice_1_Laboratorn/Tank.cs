using Exercise_1.Basic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    /// <summary>
    /// Резервуар
    /// </summary>
    class Tank : Entity
    {

        public int Volume { get; private set; }

        public int MaxVolume { get; private set; }

        public Guid UnitId { get; set; }

        public Tank(Guid tankId, string name, string description, int volume, int maxVolume, Guid unitId) : base(tankId, name, description)
        {
            if (ChangeMaxVolume(maxVolume) == false) // Если значение некорректно, вызываем исключение 
                throw new Exception("Некорректно значение"); // вызываем исключение
            if (ChangeVolume(volume, maxVolume) == false) // Если значение некорректно, вызываем исключение 
                throw new Exception("Некорректное значение"); // вызываем исключение

            UnitId = unitId;
        }

        /// <summary>
        /// Метод для изменения Максимального заполнения резервуара
        /// </summary>
        /// <param name="maxVolume">Максимальное значение заполнения резервуара</param>
        /// <returns>Флаг, корректно значение?</returns>
        public bool ChangeMaxVolume(int maxVolume)
        {
            bool flag = IntValidator.Validate(maxVolume);
            if (flag)
                MaxVolume = maxVolume;
            return flag;
        }
        /// <summary>
        /// Метод для изменения значения заполнения резервуара
        /// </summary>
        /// <param name="volume">Значение заполнения резервуара</param>
        /// <param name="maxVolume">Максимальное значение заполнения резервуара</param>
        /// <returns>Флаг, корректно значение?</returns>
        public bool ChangeVolume(int volume, int maxVolume)
        {
            bool flag = IntValidator.Validate(volume);
            if (flag && volume <= maxVolume)
                Volume = volume;
            return flag;
        }

        /// <summary>
        /// Метод, который выводит элемент, об. класс. на экран (переопределён)
        /// </summary>
        public override void Printing()
        {
            Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, Description: {this.Description}, Volume: {this.Volume}, Max Volume: {this.MaxVolume}, Unit Id: {this.UnitId}");
        }


    }


}
