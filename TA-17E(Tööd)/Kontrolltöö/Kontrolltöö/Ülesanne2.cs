using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Kontrolltöö
{
    public class Words
    {
        public int NumberOfWords(string filePath)
        {
            string text = File.ReadAllText(filePath);
            List<string> words = new List<string>();

            foreach (var word in text.Split(" "))
            {
                if (word.Any(char.IsLetter))
                {
                    words.Add(word);
                }
            }
            return words.Count();
        }

        public int NumberOfShortWords(string filePath)
        {
            string text = File.ReadAllText(filePath);
            List<string> shortWords = new List<string>();

            foreach (var word in text.Split(" "))
            {
                if (word.Any(char.IsLetter))
                {
                    if (word.Length < 5)
                    {
                        shortWords.Add(word);
                    }
                }
            }
            return shortWords.Count();
        }
    }
}
