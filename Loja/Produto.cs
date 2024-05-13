using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja;

class Produto
{

    public double preco;

    public int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }


    public double Preco {
        get => preco;
        set 
        {
            if (value < 0)
            {
                Console.WriteLine("Preço não pode ser menor que zero.");
            }
            else
            {
                preco = value;
            }

        } 
    
    }

    public int Estoque {
        get => estoque;

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Estoque não pode ser menor que zero.");
            }
            else
            {
                estoque = value;
            }
        }
   }
    public string DescricaoDetalhada
    {
        get
        {
            return $"\nO produto {Nome} possui a marca {Marca} e o preço é R${Preco},00. ";
        }
    }
    public Produto(string nome, string marca, double preco, int estoque)
    {
        Nome = nome;
        Marca = marca;
        Preco = preco;
        Estoque = estoque;
    }
    public override string ToString()
    {
        return DescricaoDetalhada;
    }

}
