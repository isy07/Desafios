using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco;

internal class Titular
{
    public string NomeDoTitular { get; set; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }

    public double Limite { get; set;}

    public Titular(string nomeDoTitular, int agencia, int numeroConta, double saldo, double limite)
    {
        NomeDoTitular = nomeDoTitular;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Saldo = saldo;
        Limite = limite;
    }

}
