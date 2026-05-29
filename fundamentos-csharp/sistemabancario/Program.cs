using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace sistemabancario
{
    internal class Program
    {
        static double saldo = 1000;
        static double sacado = 0;
        public static void depositar()
        {
            Console.WriteLine("Desejas depositar quanto?");
            double deposito = double.Parse(Console.ReadLine());
            saldo += deposito;
        }
        public static void sacar()
        {
            Console.WriteLine("Desejas sacar quanto?");

            double saque = double.Parse(Console.ReadLine());

            if (saldo < saque)
            {
                Console.WriteLine("Saldo Insuficiente");
            }
            else
            {
                saldo -= saque;
                sacado = saque;
            }
           
        }
        public static void saldo_e_sacado()
        {
            Console.WriteLine("Saldo = "+saldo);
            Console.WriteLine("Sacado = "+sacado);
        }
      

        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("---------------------------------------------------------------------Seja bem vinda ao banco Duarte---------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------Opções---------------------------------------------------------------------");
            while(option != 4)
            {

            
            Console.WriteLine("1 Depositar");
            Console.WriteLine("2 Sacar");
            Console.WriteLine("3 Ver saldo");
            Console.WriteLine("4 Sair");
             option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    depositar();
                    break;
                case 2:
                    sacar();
                    break;
                case 3:
                    saldo_e_sacado();
                    break;
                    case 4:
                    break;
                }
            }


        }
    }


} 


