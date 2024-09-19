public class Pedido
{
    public List<Produto> Produtos { get; set; }

    public Pedido()
    {
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public decimal CalcularValorTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.Preco;
        }
        return total;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Detalhes do Pedido:");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:C}");
        }
        Console.WriteLine($"Valor Total: {CalcularValorTotal():C}");
    }
}