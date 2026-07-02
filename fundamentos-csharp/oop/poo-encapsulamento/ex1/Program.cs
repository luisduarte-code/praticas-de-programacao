using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Name = "";
            p.Idade = -2;
            Console.WriteLine("Nome:"+ p.Name);
            Console.WriteLine("Idade:"+p.Idade);
        }
    }
}
