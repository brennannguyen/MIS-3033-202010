using System;
using System.IO;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\brenn\Downloads\Pride and Prejudice by Jane Austen.txt";

            // Reads the entire file into 1 SINGLE string
            //string contentsOfFile = File.ReadAllText(filePath);

            var lines = File.ReadAllLines(filePath);

            //Write a chapter out at a time
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (currentLine.Contains("Chapter"))
                {
                    Console.ReadKey();
                }

                Console.WriteLine(currentLine);
            }

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //
            //    Console.WriteLine(lines[i]);
            //
            //
            //}

            Console.WriteLine(lines);
        }
    }
}
