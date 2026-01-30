namespace MeuCrud.Models;

public class Pessoa     // Entidade Pessoa (pois possui um Id)
{
    public int Id { get; set; }     // Chave Primária
    public string Nome { get; set; }
    public int Idade { get; set; }
}
