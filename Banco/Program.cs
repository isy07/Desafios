using Banco;

Titular titular = new("Layse do Prado Oliveira Lima", 1234, 999999, 100.00, 50.00);
Conta conta = new(titular, "Itau");

Console.WriteLine(conta);



//       public string NomeDoTitular { get; set; }
//public int Agencia { get; set; }
//public int NumeroConta { get; set; }
//public double Saldo { get; set; }

//public double Limite { get; set; }
