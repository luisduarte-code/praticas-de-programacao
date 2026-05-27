using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração de uma matriz
            int i = 0;
            int j=0;
            int soma = 0;
            int[,] num = new int[3, 3];
            for ( i = 0; i < num.GetLength(0); i++)
            {
                for ( j = 0; j < num.GetLength(1); j++)
                {
                    Console.WriteLine($"Informe o numero da posição [{i}][{j}] ");

                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //para a soma total
            for (i=0; i < num.GetLength(0); i++)
            {
                for(j=0;j < num.GetLength(1); j++)
                {
                    soma += num[i, j];
                }
            }
            Console.WriteLine($"A soma da matriz é= {soma}");
        }
    }
}
