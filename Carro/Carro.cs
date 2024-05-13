class Carro
{
    public int ano;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Ano{
        get => ano;
        set
        {
            if (value < 1960 ||  value > 2023) { 
                Console.WriteLine("Ano inválido, insira um ano entre 1960 e 2023"); 
            }else{
                    ano= value;
               }
        }
    }
    public int QuantidadePortas { get; set; }

    public string DescricaoDetalhada
    {
        get
        {
            return $"\nO carro {Nome} possui a marca {Marca} e o ano de fabricação é {Ano}. ";
        }
    }
    public Carro(string nome, string marca, int ano)
    {
        Nome = nome;
        Marca = marca;
        Ano = ano;
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
    }

    public void Frear()
    {
        Console.WriteLine("Freando...");
    }

    public void Buzinar()
    {
        Console.WriteLine("Biiibiii");
    }

    public override string ToString()
    {
        return DescricaoDetalhada;
    }

}