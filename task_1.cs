c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size_array = Convert.ToInt32(Console.ReadLine());
            int[] array_num = new int[size_array];
            for (int i = 0; i < array_num.Length; i++)
            {
                array_num[i] = i + 1;
            }
            foreach (int i in array_num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
