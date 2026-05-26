using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverternum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            Console.WriteLine("Insira os numeros abaixo: ");
            for(int i = 0;i< numeros.Length; i++)
            {
                Console.WriteLine($"Insira o numero da posicao {i}");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Aqui esta a ordem dos numeros invertida");
            for (int i = numeros.Length - 1; i>=0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
