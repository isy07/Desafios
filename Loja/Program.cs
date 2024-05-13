using Loja;

Produto produto1 = new Produto("Celular", "Iphone", 2999.00, 150);
Produto produto2 = new Produto("Macbook", "Apple", 5000.00, 60);

Estoque estoque = new Estoque();

//if (produto1.Preco == 0 || produto1.Estoque == 0)
//{
//    Console.WriteLine(" ");
//}
//else
//{
//    Console.WriteLine(produto1);

//}

estoque.AdicionarProduto(produto1);
estoque.AdicionarProduto(produto2);
estoque.ExibirProduto();







