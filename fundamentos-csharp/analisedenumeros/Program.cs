using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analisedenumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[50];
            int maior = 0, menor = 0, countpar = 0, countimpar = 0, soma = 0;
            float media = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Informe os numeros " +(i+1));
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                soma += numeros[i];
                if (i == 0)
                {
                    maior = numeros[i];
                    menor = numeros[i];
                }
                else
                {
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }

                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }

                if (numeros[i] % 2 == 0)
                {
                    countpar++;
                }
                else
                {
                    countimpar++;
                }
            } //DESAFIO: mostrar os valores repetidos
            for(int i = 0; i<numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        Console.WriteLine("Valor repetido: " + numeros[i]);
                    }
                }
            }
            media = soma/50f;
            Console.WriteLine("O maior"+maior);
            Console.WriteLine("O menor"+menor);
            Console.WriteLine("Qtd pares"+countpar);
            Console.WriteLine("Qtd impares"+countimpar);
            Console.WriteLine("Media = "+media);






















        }
    }
}
