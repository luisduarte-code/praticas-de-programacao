using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Pessoa
    {
        // atributos
        public string Nome;
        public int Idade;
        
        //metodos
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
        // metodo verificar idade
       public string VerificarIdade()
        {
        return Idade >= 18 ? "Maior idade" : "Menor idade"; 
        }
    }



