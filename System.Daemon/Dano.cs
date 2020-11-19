using System.Daemon.Interface;
namespace System.Daemon
{
    public class Dano : IDano
    {
        public Dano(byte dado, byte quantidade, byte modificador)
        {
            Dado = dado;
            Quantidade = quantidade;
            Modificador = modificador;
        }
        public byte Dado { get; private set; }
        public byte Quantidade { get; private set; }
        public byte Modificador { get; private set; }
        public byte RolarDano()
        {
            throw new NotImplementedException();
        }
    }
}