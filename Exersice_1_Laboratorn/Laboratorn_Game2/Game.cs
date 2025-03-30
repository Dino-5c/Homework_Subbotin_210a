
using Laboratorn_Game2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using Laboratorn_Game2;

namespace Laboratorn_Game_2
{
    /// <summary>
    /// Класс Игра
    /// </summary>
    class Game
    {


        /// <summary>
        /// Метод, который запускает игру
        /// </summary>
        public static void StartGame()
        {
            int startNum = 1, lastNum = 100; // Границы игры
            int max = 0, min = 0;// Количество попыток
            int sum = 0, countGame = 0; // Сумма счета(для статистики) и количество игр 

            while (true)
            {
                //Сообщение, которое предлагает выбрать часть игры (Играть, Показать Статистику, Выйти)
                // 1. Change the range\n\t
                string messag = "Menu: \t2. Lets go to the new game\n\t" +
                    "3. Statistics\n\t4. Exit\n\t5. Change level ";


                Messag.Printing(new ConsolMessageShowing(), messag);


                int tmp = 0;
                Console.WriteLine("Input number");
                tmp = DoChooseValidator.Validation(tmp);
                /*while (!int.TryParse(Console.ReadLine(), out tmp) || tmp < 1 || tmp > 4)
                {
                    Console.WriteLine("Error! Input another number in [1;5].");
                } */
                // оператор выбора
                switch (tmp)
                {
                    case 5:
                        // Выбор сложности
                        Messag.Printing(new ConsolMessageShowing(), "Choose level:\n\t 1. Easy.\n\t 2.Medium.\n\t 3.Hard. ");
                        int selecting;
                        while (!int.TryParse(Console.ReadLine(), out selecting) || selecting < 1 || selecting > 3)
                        {
                            Messag.Printing(new ConsolMessageShowing(), "Error! Input another number in [1;3].");

                        }

                        switch (selecting)
                        {
                            case 1:
                                // Лёгкий уровень
                                Messag.Printing(new ConsolMessageShowing(), "Easy Level");
                                Messag.Printing(new ConsolMessageShowing(), "Range [1;20]");
                                // if (!SetMinMax(0, 20))) 
                                //  throw new Exception("Err"); 
                                startNum = 1;
                                lastNum = 20;
                                break;
                            case 2:
                                // Средний уровень
                                Messag.Printing(new ConsolMessageShowing(), "Medium Level");
                                Messag.Printing(new ConsolMessageShowing(), "Range [1, 100]");
                                startNum = 1;
                                lastNum = 100;
                                break;
                            case 3:
                                // Сложный уровень
                                Messag.Printing(new ConsolMessageShowing(), "Hard Level");
                                Messag.Printing(new ConsolMessageShowing(), "Range [1; 1000]");
                                startNum = 1;
                                lastNum = 1000;
                                break;
                            default:
                                Messag.Printing(new ConsolMessageShowing(), "aab");
                                break;
                        }
                        break;
                    /* case 1://1. Change the range
                        // Изменение диапазона угадываемых чисел
                        //  , в данный моент не используется, так как есть выбор уровня
                     
                        Messag.Printing(new ConsolMessageShowing(), "Input startNumber");
                        NumberValidator.NumberValidation(startNum);

                        Messag.Printing(new ConsolMessageShowing(), "Input lastNumber");
                        NumberValidator.NumberValidation(lastNum);

                        if (startNum > lastNum)
                        {
                            int t = startNum;
                            startNum = lastNum;
                            lastNum = t;
                        } 
                        break; */
                    case 2://2. Lets go to the new game
                        // Начало игры
                        countGame++; // countGame+=1; //countGame=countGame+1;
                        int tekCount = 0;
                        int guess = 0, number = new Random().Next(startNum, lastNum + 1);
                        for (; ; )
                        {
                            tekCount++;
                            Messag.Printing(new ConsolMessageShowing(), "Input number");
 
                            guess = NumberValidator.NumberValidation(guess, startNum, lastNum);
                            if (guess == number)
                            {
                                Messag.Printing(new ConsolMessageShowing(), "You are win!");
                                break;
                            }
                            if (guess > number) Messag.Printing(new ConsolMessageShowing(), "Your number is larger.");
                            else Messag.Printing(new ConsolMessageShowing(), "Your number is less.");

                        }
                        if (min == 0 || min > tekCount) min = tekCount;
                        if (max < tekCount) max = tekCount;
                        sum += tekCount;
                        break;
                    case 3://3. Statistics
                        // Статистика
                        Messag.Printing(new ConsolMessageShowing(), $"max={max}\tmin={min}\taverage={sum * 1.0 / countGame}");
                        break;
                    case 4://4. Exit
                        // Выход
                        Messag.Printing(new ConsolMessageShowing(), "See you later!");
                        return;
                    default:
                        Console.WriteLine("asd");
                        break;

                }

            }



        }

    }
}
