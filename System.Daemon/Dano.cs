using System.Diagnostics.Contracts;
using System.Daemon.Interface;
namespace System.Daemon
{
    public class Dano : Rolagem, IDano
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
        public byte RolarDano(byte ip)
        {
            var dano = RolarDado(Quantidade, Dado, Modificador - ip);
            return (dano <= 0) ? (byte)1 : Convert.ToByte(dano);
        }
    }
}