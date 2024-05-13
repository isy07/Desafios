using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorTreinando;

internal class CatalogoJogos
{
    private List<Jogos> Jogos {  get; set; }

    //Propriedade que retorna se o catálogo está vazio
    public bool CatalogoVazio => Jogos.Count == 0;

    //Construtor para inicializar o catálogo de jogos vazio

    public CatalogoJogos()
    {
        Jogos = new List<Jogos>();
    }

    //Método para adicionar um jogo ao catálogo
    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogos novoJogo = new Jogos(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\"adicionar ao catálogo");
    }

    //Método para listar todos os jogos no catálogo

    public void ListarJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio.");
        }
        else
        {
            Console.WriteLine("Catálogo de jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: { jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }
}
