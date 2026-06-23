// estancio o novo objeto de nome c1= carro 1
Carro c1 = new Carro();
//atribuo o meotod acelerar 50 km/h
c1.Acelerar(50);
//depois frear 30 km/h
c1.Frear(30);
// aqui peço a velocidade atual do carro.
Console.WriteLine($"Velocidade atual {c1.VelocidadeAtual}");