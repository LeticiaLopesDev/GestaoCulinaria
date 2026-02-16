namespace GestaoCulinaria.Domain.Entities;

public class Produto(string nome, decimal preco)
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = nome;
    public decimal Preco { get; private set; } = preco;
}