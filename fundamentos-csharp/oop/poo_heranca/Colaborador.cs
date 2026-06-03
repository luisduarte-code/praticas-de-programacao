using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Colaborador : Pessoa
{
// atributos
private string? _cargo;
private double _salario;
// contructor
public Colaborador(string nome, int idade, string cargo, double salario) : base (nome,idade)
    {
       
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();

    }
     

//metodo para apresentar os dados
private void ApresentarColaborador()
    {
    Console.WriteLine($"Cargo: {_cargo}");
    Console.WriteLine($"Salário: {_salario}");
    }
}