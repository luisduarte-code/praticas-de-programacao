using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        static void Main(string[] args)
        {
            double soma = 0;
            double[] notas = new double[3];
            for (int i = 0; i<notas.Length;i++)
            {
                Console.WriteLine($"Insira a nota: ");
                notas[i]= double.Parse(Console.ReadLine());
                soma += notas[i];
            }
            double mf=soma/3;
            Console.WriteLine("A media das notas é: "+ mf);








        }
 

