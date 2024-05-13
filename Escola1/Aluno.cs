using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola1;

internal class Aluno
{
    public string Nome { get; set; }
    public string Idade { get; set;}
    public List<double> Notas { get; set; } = new List<double>();

}
