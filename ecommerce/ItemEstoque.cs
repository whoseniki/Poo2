public class ItemEstoque
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }

    public ItemEstoque(string nome, int quantidade)
    {
        Nome = nome;
        Quantidade = quantidade;
    }
}

public class ControleEstoque
{
    private List<ItemEstoque> itens = new List<ItemEstoque>();

    public void AdicionarItem(ItemEstoque item)
    {
        itens.Add(item);
    }

    public void RemoverItem(string nome)
    {
        var item = itens.Find(i => i.Nome == nome);
        if (item != null)
        {
            itens.Remove(item);
        }
    }

    public void ListarItens()
    {
        foreach (var item in itens)
        {
            Console.WriteLine($"Item: {item.Nome}, Quantidade: {item.Quantidade}");
        }
    }
}







