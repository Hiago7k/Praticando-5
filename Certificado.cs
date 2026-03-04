namespace Praticando_5;

internal class Certificado 
{
    public Profissao Profissao;
    public Certificado(Profissao profissao)
    {
        Profissao = profissao;
    }
    public void AdicionarCertificado()
    {
        Console.WriteLine($"Certificado emitido para : {Profissao.Titulo}");
    }
    


}
