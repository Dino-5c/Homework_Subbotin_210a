using Exercise_1.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    /// <summary>
    /// Установка
    /// </summary>
    class Unit : Entity
    {
        public Guid FactoryId { get; }
        public Unit(Guid unitId, string name, string description, Guid factoryId) : base(unitId, name, description)
        {
            FactoryId = factoryId;
        }

        /// <summary>
        /// Метод, который выводит элемент, об. класс. на экран (переопределён)
        /// </summary>
        public override void Printing()
        {
            Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, Description: {this.Description}, Factory Id {this.FactoryId}");
        }


    }
}
