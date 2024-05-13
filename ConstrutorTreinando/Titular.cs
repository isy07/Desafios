using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorTreinando;

internal class Titular
{
    public Titular(string nome, string CPF, string endereco)
    {
        Nome = nome;
        CPF = CPF;
        Endereco = endereco;
    }

    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
}


