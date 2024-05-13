class ContaBancaria
{
    public int  NumeroIndicador {  get; set; }
    public string Titular {  get; set; }
    public double Saldo {  get; set; }
    public int Senha { get; set;}

    public void ExibirDadosConta()
    {
        Console.WriteLine($"Numero da conta: {NumeroIndicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }
}
