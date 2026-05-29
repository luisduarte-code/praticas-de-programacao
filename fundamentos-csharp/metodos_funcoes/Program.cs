using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_funcoes
{
    internal class Program
    {
        
        public static int soma(int x, int y)
        {
            return x + y;
        }
    
        //n pertence a uma classe     Tipo de retorno que é void              Nome do método       Parametros
        static                        void                                    Main                (string[] args)
        {
        //procedimentos nao retornam nada e funcoes retornam alguma coisa
            Console.WriteLine("Informe o x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A soma é = {soma (x,y)}");
        }
    }
}
