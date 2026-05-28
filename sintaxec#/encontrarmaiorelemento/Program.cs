using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace encontrarmaiorelemento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int maior = 0,linha = 0,coluna = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int  j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Informe o os numeros:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                        linha = i;
                        coluna = j;

                    }
                }
            }
            Console.WriteLine($"O maior numero é: {maior}");
            Console.WriteLine($"Linha: {linha}");
            Console.WriteLine($"Coluna: {coluna}");

















        }
    }
}
