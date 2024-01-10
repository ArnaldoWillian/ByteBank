ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;

ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

contaDaGabrielaCosta.titular = "Gabriela";
contaDaGabrielaCosta.agencia = 863;
contaDaGabrielaCosta.numero = 863452;

contaDaGabriela = contaDaGabrielaCosta;
Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);


contaDaGabriela.saldo = 300;
Console.WriteLine(contaDaGabriela.saldo);
Console.ReadLine();