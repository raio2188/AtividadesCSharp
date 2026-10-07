using Exercicio04Contas;

Conta primeira = new Conta();

primeira.Titular = "Rafael Altieris Vorcaro";
primeira.Numero = "001";
primeira.Saldo = 0;

Conta segunda = new Conta();

segunda.Titular = "Gustavo";
segunda.Numero = "002";
segunda.Saldo = 0;

primeira.Depositar(200.00);
Console.WriteLine(); // Pular Linha
primeira.Sacar(50.00);
Console.WriteLine(); // Pular Linha
primeira.Sacar(200.00);
Console.WriteLine(); // Pular Linha
primeira.Depositar(-10.00);
Console.WriteLine(); // Pular Linha
segunda.Depositar(80.00);
Console.WriteLine(); // Pular Linha
segunda.Sacar(80.00);
Console.WriteLine(); // Pular Linha
segunda.Sacar(0.00);