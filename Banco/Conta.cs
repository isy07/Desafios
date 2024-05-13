using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banco;

internal class Conta
{
        public Titular Titular { get; set; }    
        public string NomeBanco  { get; set; }
        public string DescricaoConta
        {
            get
            {
            return
            $"Banco: {NomeBanco}\nNome do Titular: {Titular.NomeDoTitular}\nAgência:{Titular.Agencia}\nConta:{Titular.NumeroConta}\nSaldo: {Titular.Saldo}\nLimite: {Titular.Limite}";
            }
        }

    public Conta(Titular titular, string nomeBanco)
    {
        Titular = titular;
        NomeBanco = nomeBanco;
        
    }

    public override string ToString()
    {
        return DescricaoConta;
    }
  
        
 

}
