using System.Daemon.Utils;

namespace System.Daemon.Interface
{
    public interface ICabecalho
    {
        string Nome { get; }
        string Sobrenome { get; }
        DateTime DataNascimento { get; }
        string LocalDeNascimento { get; }
        Genero Sexo { get; }
        byte IdadeAparente { get; set; }
        byte IdadeReal { get; set; }
    }
}