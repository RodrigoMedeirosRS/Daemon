using System.Daemon.Utils;

namespace System.Daemon.Interface
{
    public interface ICabecalho
    {
        string Nome { get; set; }
        string Sobrenome { get; set; }
        DateTime DataNascimento { get; set; }
        string LocalDeNascimento { get; set; }
        Genero Sexo { get; set; }
        byte IdadeAparente { get; set; }
        byte IdadeReal { get; set; }
    }
}