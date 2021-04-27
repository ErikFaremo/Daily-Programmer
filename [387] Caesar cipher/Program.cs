using System;
using System.Collections.Generic;

namespace _387__Caesar_cipher
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            CaesarCipher casearCipher = new();

            Console.WriteLine("Daily Programmer!");
            Console.WriteLine("[2021-04-26] Challenge #387 [Easy] Caesar cipher");
            Console.WriteLine("----------");
            Console.WriteLine("Warmup:");
            Console.WriteLine(casearCipher.Warmup("a", 0));
            Console.WriteLine(casearCipher.Warmup("a", 1));
            Console.WriteLine(casearCipher.Warmup("a", 5));
            Console.WriteLine(casearCipher.Warmup("a", 26));
            Console.WriteLine(casearCipher.Warmup("d", 15));
            Console.WriteLine(casearCipher.Warmup("z", 1));
            Console.WriteLine(casearCipher.Warmup("q", 22));
            Console.WriteLine("----------");
            Console.WriteLine("Challenge:");
            Console.WriteLine(casearCipher.Caesar("a", 1));
            Console.WriteLine(casearCipher.Caesar("abcz", 1));
            Console.WriteLine(casearCipher.Caesar("irk", 13));
            Console.WriteLine(casearCipher.Caesar("fusion", 6));
            Console.WriteLine(casearCipher.Caesar("dailyprogrammer", 6));
            Console.WriteLine(casearCipher.Caesar("jgorevxumxgsskx", 20));
        }

        private string Warmup(string letter, int index)
        {
            List<String> alphabet = GetAlphabet();

            int currentIndex = alphabet.FindIndex(x => x == letter);
            int searchIndex = (currentIndex + (index % 26)) % 26;

            return alphabet[searchIndex];
        }

        private string Caesar(string input, int index)
        {
            char[] inputArray = input.ToCharArray();
            string result = "";
            for(int i = 0; i < inputArray.Length; i++)
            {
                result += Warmup(inputArray[i].ToString(), index);
            }
            return result;
        }

        private List<string> GetAlphabet ()
        {
            List<string> alphabet = new();
            for (int i = 97; i <= 122; i++)
            {
                alphabet.Add(((char)i).ToString());
            }
            return alphabet;
        }
    }
}
