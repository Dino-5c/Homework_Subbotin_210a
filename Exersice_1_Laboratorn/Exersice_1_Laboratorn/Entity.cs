using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1.Basic
{
    /// <summary>
    /// Базовый класс сущность
    /// </summary>
    class Entity
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Entity(Guid id, string name, string description)
        {
            // string id = Guid.NewGuid().ToString();
            Id = id;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Метод, который выводит элемент, об. класс. на экран
        /// </summary>
        public virtual void Printing()
        {
            Console.WriteLine($"Id: {this.Id}, Name: {this.Name}, Description: {this.Description}");
        }

        /// <summary>
        /// Метод, который выводит на экран массив элементов
        /// </summary>
        /// <param name="entities">Массив элементов</param>
        public virtual void PrintAllEntities(Entity[] entities)
        {
            if (entities == null)
            {
                Console.WriteLine("Массив пуст");
                return;
            }
            for (int i = 0; i < entities.Length; i++)
            {
                entities[i].Printing();
            }
            Console.WriteLine();
        }

    }
}
