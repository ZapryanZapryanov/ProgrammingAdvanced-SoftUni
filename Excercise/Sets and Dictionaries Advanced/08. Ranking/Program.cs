using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> dct = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            while (input != "end of contests")
            {
                string[] elements = input.Split(":");
                string contest = elements[0];
                string passrow = elements[1];
                dct.Add(contest, passrow);

                input = Console.ReadLine();
            }
            string cmd = Console.ReadLine();

            while (cmd != "end of submissions")
            {
                string[] cmdArg = cmd.Split("=>");
                string contest = cmdArg[0];
                string pass = cmdArg[1];
                string username = cmdArg[2];
                int points = int.Parse(cmdArg[3]);

                if (dct.ContainsKey(contest))
                {
                    if (dct.Any(x => x.Value == pass))
                    {
                        if (students.ContainsKey(username))
                        {
                            if (students[username].Any(x => x.Key == contest))
                            {
                                if (points > students[username][contest])
                                {
                                    students[username][contest] = points;
                                }
                            }
                            else
                            {
                                students[username].Add(contest, points);
                            }
                            
                        }
                        else
                        {
                            students.Add(username, new Dictionary<string, int> { { contest, points } });
                        }
                    }
                }

                cmd = Console.ReadLine();
            }

            Dictionary<string, int> newDct = new Dictionary<string, int>();

            foreach (var item in students)
            {
                int allSum = 0;
                foreach (var itema in item.Value)
                {
                    allSum += itema.Value;
                }
                newDct.Add(item.Key, allSum);
            }

            foreach (var item in newDct.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
                break;
            }
            Console.WriteLine("Ranking:");
            foreach (var item in students.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var itema in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {itema.Key} -> {itema.Value}");
                }
            }
        }
    }
}
