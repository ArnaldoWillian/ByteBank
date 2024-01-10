using System.Diagnostics;

ContaCorrente conta = new ContaCorrente();

conta.titular = "Gabi";
Console.WriteLine(conta.titular);
Console.WriteLine(conta.agencia);
Console.WriteLine(conta.saldo);

Console.ReadLine();