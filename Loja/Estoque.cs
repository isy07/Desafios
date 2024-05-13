using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Loja;

internal class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto) 
    {
        produtos.Add(produto);
    }

    public void ExibirProduto() 
    {
        foreach(var produto in produtos)
        {
            Console.WriteLine($"{produto.DescricaoDetalhada}");

        }
    }
}

