using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ex2
    {
        static void conversor(string[] args)
        {
            Console.WriteLine("Informe a cotação do dolar atual:");
            float cd = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos reais vc tem:");
            float vr = float.Parse (Console.ReadLine());
            float conversor = cd * vr;
            Console.WriteLine($"O seu valor convertido vai ser de {conversor}");








        }
    }
}
