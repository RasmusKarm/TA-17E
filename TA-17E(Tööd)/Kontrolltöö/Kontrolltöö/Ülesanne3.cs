using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kontrolltöö
{
    public class Lists
    {
        public bool ContainsMatches(List<int> a, List<int> b)
        {
            List<int> allMatches = new List<int>();

            foreach (var num1 in a)
            {
                foreach (var num2 in b)
                {
                    if (num1 == num2)
                    {
                        allMatches.Add(num2);
                    }
                }
            }

            if (allMatches.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Max(List<int> a, List<int> b)
        {
            List<int> mergedList = new List<int>();

            foreach (var num1 in a)
            {
                mergedList.Add(num1);
            }
            foreach (var num2 in b)
            {
                mergedList.Add(num2);
            }

            return mergedList.Max();
        }

        public int Min(List<int> a, List<int> b)
        {
            List<int> mergedList = new List<int>();

            foreach (var num1 in a)
            {
                mergedList.Add(num1);
            }
            foreach (var num2 in b)
            {
                mergedList.Add(num2);
            }

            return mergedList.Min();
        }

        public int Avarage(List<int> a)
        {
            int listSum = 0;
            foreach (var num1 in a)
            {
                listSum += num1;
            }
            return listSum / a.Count();
        }

        public int AvarageOftwo(List<int> a, List<int> b)
        {
            int listSums = 0;
            foreach (var num1 in a)
            {
                listSums += num1;
            }
            foreach (var num2 in b)
            {
                listSums += num2;
            }
            return listSums / (a.Count() + b.Count());
        }
    }
}
