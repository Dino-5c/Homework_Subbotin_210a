using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameA
{
    public class RandomGeneration : IRandomGenerate
    {
        private int MaximuVal;
        private Random RandomNu;

        public RandomGeneration(int maximumNumber)
        {
            MaximuVal = maximumNumber;
            RandomNu = new Random();
        }
        public int GenerateRandomNumber()
        {
            return RandomNu.Next(1, MaximuVal + 1);
        }
    }
}
