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
        static void Main(string[] args)
        {
           int x= Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 0: Console.WriteLine("O numero é 0");
                    break;
                case 1: Console.WriteLine("O numero é 1");
                    break;
                default: Console.WriteLine("Vai a merda");
                    break;
            }
        }
    }
}
