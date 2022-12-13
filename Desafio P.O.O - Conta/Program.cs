using Desafio_P.O.O___Conta.Models;

ContaCorrente c = new ContaCorrente();
c.NomeCorrentista = "Sara Souza";
c.NumeroConta = 112705;
c.NumeroAgencia = 03;

Console.WriteLine(c.Saldo);

c.Depositar(800);
Console.WriteLine(c.Saldo);

c.Sacar(150);
Console.WriteLine(c.Saldo);

c.Sacar(30);
Console.WriteLine(c.Saldo);