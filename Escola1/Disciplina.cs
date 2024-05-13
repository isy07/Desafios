using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola1;

internal class Disciplina
{
    public List<Aluno> alunos { get; set; } = new List<Aluno>();
    public string Nome { get; set; }

}
