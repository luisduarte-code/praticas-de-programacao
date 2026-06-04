using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class ContaBancaria
    {
    //atributos
    public string Titular;
    public double Saldo = 0;

    //metodos
    public double Depositar(double deposito)
    {
        Saldo += deposito;
        return Saldo;
    }
    public double Sacar(double saque)
    {
        Saldo = Saldo - saque;
        return Saldo;
    }             
    public double ExibirSaldo()
    {
        return Saldo;
    }

}

