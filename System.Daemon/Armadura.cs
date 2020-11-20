using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Armadura : IArmadura
    {
        public Armadura(string nome, byte peso, byte valor, byte ip, int penalidadeAgilidade, int penalidadeDestreza, bool escudo)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
            IP = ip;
            PenalidadeAgilidade = penalidadeAgilidade;
            PenalidadeDestreza = penalidadeDestreza;
            Escudo = escudo;
        }
        public string Nome { get; private set; }
        public byte Peso { get; private set; }
        public byte Valor { get; private set; }
        public byte IP { get; private set; }
        public int PenalidadeAgilidade { get; private set; }
        public int PenalidadeDestreza { get; private set;  }
        public bool Escudo { get; private set; }
    }
}