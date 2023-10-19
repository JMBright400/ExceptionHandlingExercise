using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '1', '2', '3', '4', '5', '6', 'X', 'Y', 'Z' };
            List<int> numbers = new List<int>();
            string str = "";

            foreach (char  character in arr) 
            {
                try
                {
                    str = character.ToString();
                    int num = int.Parse(str);
                    numbers.Add(num);
                }
                catch (FormatException) 
                {
                    Console.WriteLine($"Unable to Parse '{character}'.");
                }
            }

            foreach (var num in numbers)
            { 
                Console.WriteLine(num);
            }

        }
    }
}
