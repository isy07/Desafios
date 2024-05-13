using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorTreinando;

internal class Conta
{
    public Conta(Titular titular, int agencia, int numeroDeConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDeConta = numeroDeConta;
        Saldo = saldo;
        Limite = limite;
    }

    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDeConta { get; set; }
    public double Saldo { get;}
    public double Limite { get; set; }
    public string DescricaoConta
    {
        get
        {
            return
            $"Nome do Titular: {Titular}\nAgência:{Agencia}\nConta:{NumeroDeConta}\nSaldo: {Saldo}\nLimite: {Limite}";
        }
    }

}
