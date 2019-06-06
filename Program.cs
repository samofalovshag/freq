using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ll
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary;
            Console.Write("Введите путь к файлу !  ");

            string text = File.ReadAllText(Console.ReadLine());

            dictionary = FreqDictionary.GetFrequenceDictionary(text);

            List<string> keys = new List<string>(dictionary.Keys);
            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(keys[i] + "\t" + dictionary[keys[i]]);
            }

            Console.ReadKey();
        }

    }
}
