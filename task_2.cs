using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size_matrix = Convert.ToInt32(Console.ReadLine());
            int[,] matrix= new int[size_matrix,size_matrix];
            for(int i=0; i < size_matrix; i++)
            {
                for(int j = 0; j < size_matrix; j++)
                {
                    if (j+1 >= i)
                    {
                        matrix[i, j] = 1;
                    }
                }

            }
            for (int i = 0; i < size_matrix; i++)
            {
                for (int j = 0; j < size_matrix; j++)
                {
                    Console.Write(matrix[i,j]+" ") ;
                }
                Console.Write("\n");
            }
        }
    }
}
