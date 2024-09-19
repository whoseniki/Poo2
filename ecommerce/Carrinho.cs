public class Carrinho
{
    public List<ItemCarrinho> Itens { get; set; }
    public decimal Total { get; set; }

    public Carrinho()
    {
        Itens = new List<ItemCarrinho>();
    }
    public void RemoverItem(int cod)
    {
        //Itens.RemoveAll(i => i.Produto.Codigo == cod);
        int indice = -1;
        foreach (ItemCarrinho item in Itens)
        {
            if (item.Produto.Codigo == cod)
            {
                indice = Itens.IndexOf(item);
            }
        }
        if (indice != -1)
        {
            Itens.RemoveAt(indice);
        }

    }
    public void AdicionarItem(ItemCarrinho item)
    {
        Itens.Add(item);
        Console.WriteLine("Item adicionado com sucesso");
    }
    public void CalcTotalCarrinho()
    {
        Total = 0;
        foreach (ItemCarrinho item in Itens)
        {
            Total = Total + (item.Produto.Preco * item.Quantidade);
        }

    }
}








