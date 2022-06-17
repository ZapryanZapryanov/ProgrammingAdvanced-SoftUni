using System;
using System.IO;

namespace _03._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
           
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
               
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int countBytes = reader.Read(buffer, 0, buffer.Length);
                        if (countBytes == 0) 
                        {
                            break; 
                        }


                        writer.Write(buffer, 0, countBytes);
                    }
                }
            }
        }
    }
}
