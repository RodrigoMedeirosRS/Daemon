using System.Daemon.Utils;

namespace System.Daemon.Interface
{
    public interface IAtributo
    {
        NomeAtributo Nome { get; }
        byte Valor { get; set; }
        int Modificador { get; set; }
        float Teste { get; }
        string Porcentagem { get; }
    }
}