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
            // declaração de uma matriz e demais variaveis
            int i = 0, j = 0, soma = 0;
            int[,] num = new int[3, 3];
            for ( i = 0; i < num.GetLength(0); i++)//percorre linha
            {
                for ( j = 0; j < num.GetLength(1); j++)//percorre coluna
                {
                    Console.WriteLine($"Informe o numero da posição [{i}][{j}] ");

                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //para a soma total
            for (i=0; i < num.GetLength(0); i++)//funcao que retorna o tamanho da linha
            {
                for(j=0;j < num.GetLength(1); j++)// colocando o 1 na frente retorna o tamanho da coluna
                {
                    soma += num[i, j];
                }
            }
            //retorna a soma total
            Console.WriteLine($"A soma da matriz é= {soma}");
        }
    }
}
