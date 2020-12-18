using System.Daemon.Utils;
namespace System.Daemon.Interface
{
    public interface IMecanica
    {
        bool Teste(float valor, Dificuldade dificuldade = Dificuldade.Normal);
        bool TesteResistido(float valorPassivo, float valorAtivo);
        bool TesteAuxiliado(float valor, float valorAuxiliar);
    }
}