
namespace Praticando_5;

internal class Pergaminho : ItemDigital
{
    public string Armazenar { get; set; }
    public Pergaminho(string titulodoitem, string armazenar)
        :base(titulodoitem)
    {
        Armazenar = armazenar;
    }


    public void MostrarDetalhes()
    {
        Console.WriteLine($"Detalhes do Pergaminho");
        Console.WriteLine($"Titulo: {TituloDoItem}");
        Console.WriteLine($"Descricao {Armazenar}");
    }
}
