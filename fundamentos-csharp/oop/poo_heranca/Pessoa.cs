using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pessoa
{
    // Atributos 
    private string? _nome;
    private int _idade;
    //construtor
    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }
    //metodo para apresentar os dados
    protected void ApresentarPessoa() 
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine($"Idade: {_idade}");
    }
}