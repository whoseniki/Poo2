public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public Cliente(string nome, string email, int telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }


    public void ExibirDetalhes(){
    Console.Writeline ($"Nome: {Nome} , Email: {Email} , Telefone: {Telefone}");
    }
}

