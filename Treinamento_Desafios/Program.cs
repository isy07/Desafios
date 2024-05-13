ContaBancaria conta = new ContaBancaria();
conta.NumeroIndicador = 123;
conta.Titular = "Layse Prado";
conta.Saldo = 100.00;
conta.Senha = 987654;

Console.WriteLine($"O titular da conta é {conta.Titular} e o saldo é {conta.Saldo} reais");

conta.ExibirDadosConta();




