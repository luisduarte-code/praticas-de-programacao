using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Produto
{
    //atributos
    public string Nome;
    public double Preco;
    public int Qtd;

    //metodos

    
    public double ValorEstoque()
    {

        return Qtd * Preco;
    }





}






