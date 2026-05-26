using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class comissao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do vendedor: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o código da peça: ");
            int cp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o valor da peça: ");
            float vp = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de peças vendidas: ");
            int qtdsell = Convert.ToInt32(Console.ReadLine());
            float cvendedor = (vp * qtdsell) * 0.05f;
            Console.WriteLine($"A comissao do vender sera de: {cvendedor}");
        }

    }
}
