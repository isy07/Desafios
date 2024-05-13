using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante;

internal class Restaurante
{
    public List <Mesa> Mesas { get; set; } = new List <Mesa> ();
    public Cardapio Cardapio { get; set; } = new Cardapio();
}
