using System;using System.Collections.Generic;
using System.Linq;using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp7{
    internal class Program    {
        static void Main(string[] args)        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[N,N];            int i = 0, j, k = 0, p = 1;
            while (i < N * N) /*Цикл по номеру витка*/
            {                k++;
                for (j = k - 1; j < N - k + 1; j++)
                {
                    matrix[k - 1,j] = p++; i++;
                }   /*Определение значений верхнего гор столбца*/
                for (j = k; j < N - k + 1; j++)
                {
                    matrix[j,N - k] = p++; i++;
                }   /* --//-- По правому вертикальному столбцу*/
                for (j = N - k - 1; j >= k - 1; j--)
                {
                    matrix[N - k,j] = p++; i++;
                }   /* --//-- по нижнему горизонтальному столбцу*/
                for (j = N - k - 1; j >= k; j--)
                {
                    matrix[j,k - 1] = p++; i++;
                }   /* --//-- по левому вертикальному столбцу*/
            }
            for (int q = 0; q < N; q++)
            {
                for (int w = 0; w < N; w++)
                {
                    Console.Write(matrix[q, w] + "\t");
                }
                Console.Write("\n");
                }
        }    }
}
