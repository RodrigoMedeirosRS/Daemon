using System.Diagnostics.Contracts;
using System.Daemon.Interface;
namespace System.Daemon
{
    public class Dano : Rolagem, IDano
    {
        public Dano(byte quantidade, byte dado,  byte modificador)
        {
            Dado = dado;
            Quantidade = quantidade;
            Modificador = modificador;
            Bonus = 0;
        }
        public byte Dado { get; private set; }
        public byte Quantidade { get; private set; }
        public byte Modificador { get; private set; }
        public byte Bonus { get; set; }
        public byte RolarDano(byte ip)
        {
            var dano = RolarDado(Quantidade, Dado, Modificador - ip + Bonus);
            return (dano <= 0) ? (byte)1 : Convert.ToByte(dano);
        }
    }
}