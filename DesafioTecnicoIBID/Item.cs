namespace DesafioTecnicoIBID;

public class Item
{
    public int ID { get; set; }
    public string? Nome { get; set; }

    public Item(int id, string nome)
    {
        this.Nome = nome;
        this.ID = id;
    }

    public Item()
    {
    }
}
