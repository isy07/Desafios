using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorTreinando;

internal class Jogos
{
    public Jogos(string nome, string genero, int anoLancamento)
    {
        Nome = nome;
        Genero = genero;
        AnoLancamento = anoLancamento;
    }


    public string Nome { get; set; }
    public string Genero { get; set; }
    public int AnoLancamento { get; set; }

}
