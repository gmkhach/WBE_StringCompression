﻿/*
 * Implement a method to perform basic string compression using the counts of repeated characters. 
 * For example, the string "aabcccccaaa" would become "a2b1c5a3". If the "compressed" string would not become smaller than the original string, 
 * your method should return the original string. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter a test string\n\n>>> ");
                    string input = Console.ReadLine().Trim();
                    Console.WriteLine("\nCompressed string: " + Compress(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        private static string Compress(string input)
        {
            string output = "";
            int counter = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1 && input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    // output = input[i] + counter; would evaulated the right side of the assignment as a number, so string interpolation is used instead.
                    output += $"{input[i]}{counter}";
                    counter = 1;
                }
            }
            // if the compressed string is not any shorter the input is returned.
            return output.Length < input.Length ? output : input;
        }
    }
}
