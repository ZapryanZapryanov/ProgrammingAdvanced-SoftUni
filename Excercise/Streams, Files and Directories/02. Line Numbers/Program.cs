using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt"; 
            string outputFilePath = @"..\..\..\output.txt"; 

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            int count = 0;
            List<string> outputLines = new List<string>();

            foreach (string line in lines)
            {
               
                count++;

                int countLetters = line.Count(char.IsLetter); //37
               
                int countSymbol = line.Count(char.IsPunctuation); //4
              
                string modifiedLine = $"Line {count}: {line} ({countLetters})({countSymbol})";
             
                outputLines.Add(modifiedLine);

            }
            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}
