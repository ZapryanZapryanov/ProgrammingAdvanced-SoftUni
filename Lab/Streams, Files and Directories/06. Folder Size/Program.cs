﻿using System;

namespace _06._Split__Merge_Binary_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("TestFolder");
            string[] files = Directory.GetFiles(path);

            long size = 0;
            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                size += fi.Length;
            }

            path = Path.Combine("TestFolder", "output.txt");
            File.WriteAllText(path, $"{(double)size / (1024 * 1024)}");
        }
    }
}
