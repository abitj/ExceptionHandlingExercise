using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* First create an char[], it must contain 6 numbers and 3 letters - name it arr
             * Create a list called numbers that will hold integers
             * Create an string variable with an empty string initializer - name it str
             *  using a foreach loop, attempt to parse the elements in your char[] with int.Parse() and Exceptions will be thrown
            */
            var numbers = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };
            var numInt = new List<int>();
            var str = "";

            foreach(var item in numbers) 
            {
                try
                {
                    str = item.ToString();
                    var num = int.Parse(str);
                    numInt.Add(num);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");

                }
                finally
                {
                    Console.WriteLine("printed");
                }
            } 

            foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
        }
    }
}
