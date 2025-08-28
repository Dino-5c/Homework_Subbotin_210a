using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameA
{
    public class NumberGame1
    {
        private readonly IRandomGenerate RandomGenerate;
        private readonly IEnter Enter;
        private readonly IPrinting Printing;
        private readonly int RandomNumber;

        public NumberGame1(IRandomGenerate randomGenerate, IEnter enter, IPrinting printing)
        {
            RandomGenerate = randomGenerate;
            Enter = enter;
            Printing = printing;
            RandomNumber = randomGenerate.GenerateRandomNumber();
        }

        public void Start()
        {
            Printing.Print("Старт игры ");

            while(true)
            {
                int number = Enter.UserNumberEntering();

                if(number == RandomNumber)
                {
                    Printing.Print("Вы победили!");
                    break;
                }

                if(number < RandomNumber)
                {
                    Printing.Print("Случайное число больше ");
                }

                if(number > RandomNumber)
                {
                    Printing.Print("Случайное число меньше ");
                }
            }
        }
    }
}
