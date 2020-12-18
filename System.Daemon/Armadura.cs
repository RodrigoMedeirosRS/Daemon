using System.Daemon.Interface;

namespace System.Daemon
{
    public class Armadura : IArmadura
    {
        public Armadura(string nome, byte peso, byte valor, byte ip, bool escudo = false)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
            IP = ip;
            Escudo = escudo;
        }
        public string Nome { get; private set; }
        public byte Peso { get; private set; }
        public byte Valor { get; private set; }
        public byte IP { get; private set; }
        public bool Escudo { get; private set; }
    }
}