
namespace Praticando_5;

abstract class Profissao
{
    protected Profissao(string titulo)
    {
        Titulo = titulo;
    }

    public string Titulo { get;  }
}
