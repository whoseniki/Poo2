var produto1 = new Produto(1, "Mouse", 24.5M);
var produto2 = new Produto(2, "Teclado", 50.5M);

var cliente1 = new Cliente("Samanta", "samanta4@gmail.com", 997445678);

var ItemCarrinho1 = new ItemCarrinho(produto1, 10);
var ItemCarrinho2 = new ItemCarrinho(produto2, 2);
Console.WriteLine(ItemCarrinho1.Produto.Nome);

var Carrinho1 = new Carrinho();
Carrinho1.AdicionarItem(ItemCarrinho1);
Carrinho1.AdicionarItem(ItemCarrinho2);

Console.WriteLine(Carrinho1.Itens[0].Produto.Nome);
Console.WriteLine(Carrinho1.Itens[1].Produto.Nome);
//Carrinho1.RemoverItem(2);
//Console.WriteLine("Depois de Removido");
//Console.WriteLine(Carrinho1.Itens[0].Produto.Nome);

Console.WriteLine("Calculando o Total do Carrinho");
Carrinho1.CalcTotalCarrinho();
Console.WriteLine(Carrinho1.Total);

var Pedido = new Pedido(1, cliente1, Carrinho1);
Console.WriteLine("Total do Pedido: " + Pedido.Total().ToString());
Console.WriteLine("Impostos : " + Pedido.CalcularImposto().ToString());


