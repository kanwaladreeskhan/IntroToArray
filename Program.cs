using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int index1 = 0, index2 = 0;
            Console.WriteLine("Enter elements:(Ranging from 1 to 50!)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (A[i] + A[j] == 25)
                    {
                        index1 = i; index2=j;
                        Console.WriteLine("For index {0} and {1},sum is 25.", index1, index2);
                    }
                }
            }
        }
    }
}
