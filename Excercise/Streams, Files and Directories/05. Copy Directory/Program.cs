using System;
using System.IO;

namespace _05._Copy_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
            
            Directory.CreateDirectory(outputPath);
           
            string[] files = Directory.GetFiles(inputPath);

          
            foreach (string file in files)
            {
                var fileName = Path.GetFileName(file); 
                var copyDestination = Path.Combine(outputPath, fileName);
                File.Copy(fileName, copyDestination);
            }
        }
    }
}
