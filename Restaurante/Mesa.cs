using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante;

internal class Mesa
{
    public int NumeroMesa { get; set; }
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
