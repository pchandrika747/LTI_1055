using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace ConsoleApp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            fruits[0] = "Bananna";
            fruits[1] = "Apple";
            fruits[2] = "Orange";
            fruits[3] = "Pineapple";
            fruits[4] = "Kivi";

            Console.WriteLine("Give array is");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(fruits[i]);
            Console.WriteLine(". . . . . . . . .");
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }
            int[] marks = { 12, 52, 45, 36, 57, 41 };
            Console.WriteLine("Display of marks ");
            for (int i = 0; i < marks.Length; i++)
                Console.WriteLine("Marks :" + marks[i]);

            Array.Sort(fruits);
            Console.WriteLine("..... Sorted in ascending ");
            foreach(string f in fruits)
            {
                Console.WriteLine(f);
            }
            Array.Reverse(fruits);
            Console.WriteLine("..... Sorted in descending ");
            foreach (string f in fruits)
            {
                Console.WriteLine(f);
            }
            

        }
    }
}