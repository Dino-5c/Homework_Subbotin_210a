
using Exercise_1.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    /// <summary>
    /// Завод
    /// </summary>
    class Factory : Entity
    {

        public Factory(Guid id, string name, string description) : base(id, name, description)
        {

        }


        /// <summary>
        /// Метод, который выводит элемент, об. класс. на экран (переопределён)
        /// </summary>
        public override void Printing()
        {
            Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, Description: {this.Description}");
        }



    }
}
