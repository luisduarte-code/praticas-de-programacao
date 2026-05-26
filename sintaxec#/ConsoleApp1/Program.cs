using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void estoquedepecas(string[] args)
        {
         //inserir a qnt minima de peças que essa peça deve de ter no estoque 
            Console.WriteLine("Infrome a quantidade minima de peças que precisa ter no estoque: ");
            int qmin = Convert.ToInt32(Console.ReadLine());
        //qtd maxima
            Console.WriteLine("Infrome a quantidade minima de peças que precisa ter no estoque: ");
            int qmax = Convert.ToInt32(Console.ReadLine());
        //calculo da media de peças
            int em = (qmin + qmax) / 2;
        //resultado
            Console.WriteLine($"O estoque minimo é de: {em}");
        }
    }
}
