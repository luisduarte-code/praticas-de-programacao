using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addalunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[10];
            for  (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Informe os seus alunos: ");
                alunos[i] = Console.ReadLine();
            }
            Console.WriteLine("Qual alunos queres: ");
            int aluno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O {aluno}º aluno é o {alunos[aluno]}");



        }
    }
}
