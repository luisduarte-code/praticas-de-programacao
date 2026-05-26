using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ler50numemedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[50];
            int count = 0;int i = 0;
            double soma = 0, media;
            Console.WriteLine("Informe a sequência dos 50 numeros que queres inserir aqui: ");
            for( i = 0;i <num.Length; i++)
            {
                Console.WriteLine($"Informe o {i+1}º numero ");
                num [i] = Convert.ToInt32(Console.ReadLine());
                soma += num[i];
                count++;
            }
            media = soma / count;
            Console.WriteLine($"A media dos numeros é {media}");
            Console.WriteLine("Abaixo estão os números menores que a media:");
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] < media)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
