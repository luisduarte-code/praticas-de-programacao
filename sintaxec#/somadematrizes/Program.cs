using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somadematrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] matrizsoma = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Insira  os numeros:{i}{j} ");
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++) { 
            for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Insira  os numeros:{i}{j} ");
                        matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
             for (int i = 0; i < 3; i++)
             {
            for (int j = 0; j < 3; j++)
             {
                matrizsoma[i,j] = matriz1[i,j] + matriz2[i,j];
                    Console.Write(matrizsoma[i,j]);
                        
              }
                Console.WriteLine();
             }

            
        }
    }
}

