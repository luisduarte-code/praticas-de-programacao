using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     class Carro // a classe é o molde do carro, porem neste caso estamos buscando saber a velocidade dele nos momentos.
    {
    public string Marca;
    public string Modelo;
    public float VelocidadeAtual;
    public float Acelerar(float x)
    {
        VelocidadeAtual = VelocidadeAtual + x;
        return VelocidadeAtual;
    }
    public float Frear(float y)
    {
        VelocidadeAtual = VelocidadeAtual - y;
        return VelocidadeAtual;
    }
}
   
