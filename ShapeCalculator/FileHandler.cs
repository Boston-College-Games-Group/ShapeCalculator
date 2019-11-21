using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace ShapeCalculator
{
    abstract class FileHandler
    {
        static List<string> lines;

        public static void ReadFile(string filePath = @"TEST.txt")
        {
            lines = File.ReadAllLines(filePath).ToList();
        }

        public static void WriteToFile(string filePath = @"TEST.txt")
        {
            File.WriteAllLines(filePath, lines);
        }

        public static void AddContents(string filePath = @"TEST.txt", string contentsToAdd = "EXAMPLE_TEXT")
        {
            lines.Add(contentsToAdd);
        }

        public static void PrintFileToConsole()
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
