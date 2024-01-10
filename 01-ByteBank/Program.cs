ContaCorrente primeiraContaCorrente = new ContaCorrente();
primeiraContaCorrente.saldo = 200;
Console.WriteLine(primeiraContaCorrente.saldo);



primeiraContaCorrente.saldo += 100;
Console.WriteLine( primeiraContaCorrente.saldo);
Console.ReadLine();

ContaCorrente segundaContaCorrente = new ContaCorrente();
segundaContaCorrente.saldo = 50;

Console.WriteLine("A primeira conta tem: " + primeiraContaCorrente.saldo) ;
Console.WriteLine("A segunda conta tem: " + segundaContaCorrente.saldo);

Console.ReadLine() ;