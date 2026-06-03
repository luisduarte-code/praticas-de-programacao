using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Aluno()
{
    //1º maneira
    private string? _nome;
    
    public string? Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    //2º maneira
   public double Media { get; set; }

}
