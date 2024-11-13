using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] result = new int[length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = num * i;
                foreach (var item in result )
                {
                    Console.Write($"{item}");
                }
            }
            Console.ReadLine();
        }
    }
}
