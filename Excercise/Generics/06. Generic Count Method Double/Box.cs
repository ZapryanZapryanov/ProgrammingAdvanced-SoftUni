﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Generic_Count_Method_Double
{
    
        public class Box<T> : IComparable<T> where T : IComparable<T>

        {
            public Box(T element)
            {
                Element = element;
            }

            public Box(List<T> elemntsList)
            {
                Elements = elemntsList;
            }

            public List<T> Elements { get; }

            public T Element { get; }

            public void Swap(List<T> elements, int indexOne, int indexTwo)
            {
                T firstEl = elements[indexOne];
                elements[indexOne] = elements[indexTwo];
                elements[indexTwo] = firstEl;
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                foreach (T element in Elements)
                {
                    sb.AppendLine($"{element.GetType()}: {element}");
                }

                return sb.ToString().TrimEnd();
                //return $"{typeof(T)}: {Element}";
            }

            public int CompareTo(T other) => Element.CompareTo(other);

            public int CountOFGreaterElements<T>(List<T> list, T readLine) where T : IComparable
                => list.Count(word => word.CompareTo(readLine) > 0);
        }
        }
    
