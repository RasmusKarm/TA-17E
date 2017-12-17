using System;
using System.Collections.Generic;

namespace Kontrolltöö
{
    public class EvenNumbers
    {
        public List<int> GetEvens(int firstNum, int secondNum)
        {
            List<int> evens = new List<int>();

            for (int i = firstNum+1; i <= secondNum-1; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
            }
            return evens;
        }
    }
}
