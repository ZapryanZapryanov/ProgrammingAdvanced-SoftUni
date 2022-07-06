using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int count = 0;
            List<string> listWords = new List<string>();
            foreach (char item in input)
            {
                listWords.Add(item.ToString());
            }
            string[,] matrix = new string[rowAndCol[0], rowAndCol[1]];
            

            for (int i = 0; i < rowAndCol[0]; i++)
            {
                if (i % 2 == 0)
                {
                    for (int a = 0; a < rowAndCol[1]; a++)
                    {
                        
                        matrix[i, a] = listWords[count];
                        count++;
                        if (count == listWords.Count)
                        {
                            count = 0;
                        }

                    }
                    
                }
                else
                {
                    for (int r = rowAndCol[1] - 1; r >= 0; r--)
                    {
                       
                        matrix[i, r] = listWords[count];
                        count++;
                        if (count == listWords.Count)
                        {
                            count = 0;
                        }

                    }
                }
            }
            for (int i = 0; i < rowAndCol[0]; i++)
            {
                for (int a = 0; a < rowAndCol[1]; a++)
                {
                    Console.Write(matrix[i,a]);
                }
                Console.WriteLine();
            }
        }
       
        
    }
}
