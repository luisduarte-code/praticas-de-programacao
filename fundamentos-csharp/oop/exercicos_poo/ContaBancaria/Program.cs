ContaBancaria c1 = new ContaBancaria();
Console.WriteLine("Informe o nome do titular da conta: ");
c1.Titular = Console.ReadLine();
c1.Depositar(500);
c1.Sacar(150);
c1.ExibirSaldo();
Console.WriteLine($"O {c1.Titular} tem na conta {c1.ExibirSaldo()}");



