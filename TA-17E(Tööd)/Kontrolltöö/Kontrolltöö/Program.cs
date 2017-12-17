using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kontrolltöö
{
    class Program
    {
        static void Main(string[] args)
        {
            //KONTROLLTÖÖ
            Console.WriteLine("KONTROLLTÖÖ");
            EvenNumbers evens = new EvenNumbers();
            Words words = new Words();
            Lists lists = new Lists();

            //1. ÜLESANNE
            Console.WriteLine("ESIMENE ÜLESANNE.");
            Console.WriteLine("");
            Console.WriteLine("Sisesta kaks arvu");
            Console.Write("Esimene arv: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Teine arv: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nende arvude vahele jäävad paaris arvud ");
            List<int> evenNumbers = evens.GetEvens(firstNum,secondNum);
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //2. ÜLESANNE
            Console.WriteLine("TEINE ÜLESANNE.");
            Console.WriteLine("");
            string textFilePath = "kttekst.txt";
            Console.WriteLine($"Kontrolltöö tekstifailis on ilma numbriteta {words.NumberOfWords(textFilePath)} sõna,");
            Console.WriteLine($"millest {words.NumberOfShortWords(textFilePath)} on lühemad kui 5 tähte.");
            Console.ReadKey();
            Console.WriteLine("");

            //3. ÜLESANNE
            Console.WriteLine("KOLMAS ÜLESANNE");
            Console.WriteLine("");

            List<int> list1 = new List<int>()
            {
                11,15,6,13,13,25,32,11,20,5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24
            };
            List<int> list2 = new List<int>()
            {
                5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7
            };

            //1.)
            if (lists.ContainsMatches(list1,list2))
            {
                Console.WriteLine("1.) Jah, listides leidub sarnaseid elemente.");
            }
            else
            {
                Console.WriteLine("1.) Ei, listides ei leidu sarnaseid elemente.");
            }
            Console.WriteLine("");

            //2.)
            Console.WriteLine($"2.) Kahe listi suurim number on {lists.Max(list1,list2)}");
            Console.WriteLine("");

            //3.)
            Console.WriteLine($"3.) Kahe listi väikseim number on {lists.Min(list1,list2)}");
            Console.WriteLine("");





            //4.)
            Console.WriteLine($"4.) Esimese listi keskmine on {lists.Avarage(list1)}");
            Console.WriteLine("");
            Console.WriteLine($"5.) Teise listi keskmine on {lists.Avarage(list2)}");
            Console.WriteLine("");
            Console.WriteLine($"4.) Kahe listi keskmine on {lists.AvarageOftwo(list1,list2)}");
            Console.ReadKey();
        }
    }
}
