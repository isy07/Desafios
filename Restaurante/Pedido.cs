using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante;

internal class Pedido
{
    public ProdutoRestaurante Produto { get; set; }
    public int Quantidade { get; set; }
}
