using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queueSongs = new Queue<string>(songs);

            while (queueSongs.Count > 0)
            {
                string[] cmdArg = Console.ReadLine().Split(" ");
                if (cmdArg[0] == "Play")
                {
                    queueSongs.Dequeue();
                }
                else if (cmdArg[0] == "Add")
                {
                    string currSong = string.Join(" ", cmdArg);
                    string newStr = currSong.Substring(4);
                    if (queueSongs.Contains(newStr))
                    {
                        Console.WriteLine($"{newStr} is already contained!");
                    }
                    else
                    {
                        queueSongs.Enqueue(newStr);
                    }
                }
                else if (cmdArg[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueSongs));
                }
                
            }
            Console.WriteLine("No more songs!");
        }
      
    }
}
