﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversWord
{
    class Program
    {
        static string[] GetArrayStringSplit(string inputString)
        {
            char[] separators = new char[] { ' ', '.', ',', '?', '!', ':', ';', '(', ')', '\"', '\"', '\'', '\'' };
            string[] ArrayStringSplit = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return ArrayStringSplit;
        }

        static void ReversWords(string phrase)
        {
            string[] ArrayReversWord = GetArrayStringSplit(phrase);
            string outputString = "";

            for (int i = 0; i < ArrayReversWord.Length; i++)
            {
                outputString = outputString + ArrayReversWord[i];
            }

            Console.WriteLine($">>>  {outputString}");
        }

        static void Print(string InputUserPhrase)
        {
            string[] ArrayUserString = GetArrayStringSplit(InputUserPhrase);

            Console.WriteLine("\nРезультат:");
            foreach (string SplitUserString in ArrayUserString)
            {
                ReversWords(SplitUserString);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Разделение предложения на слова.");

            Console.Write("Введите предложение: ");
            string UserString = Console.ReadLine();
            if (UserString == "")
            {
                Console.WriteLine("\nСтрока пустая. Пожалуйста, введите предложение, чтобы разделить на слова.");
            }
            else
            {
                Print(UserString);
            }

            Console.ReadKey();
        }
    }
}
