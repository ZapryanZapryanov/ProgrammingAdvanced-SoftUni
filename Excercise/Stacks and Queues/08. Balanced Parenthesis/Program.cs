using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

          

            Stack<char> stack = new Stack<char>(input);

            int flag = 0;
            foreach (var item in input)
            {
                
                
                char firstElement = stack.Pop();
                if ((item == '[' || item == ']') && (firstElement == '[' || firstElement == ']'))
                {
                    
                    continue;
                }
                else if ((item == '(' || item == ')') && (firstElement == '(' || firstElement == ')'))
                {
                  
                    continue;
                }
                else if ((item == '{' || item == '}') && (firstElement == '{' || firstElement == '}'))
                {
                   
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                
                
            }
           
                Console.WriteLine("YES");
            
            
        }
    }
}
