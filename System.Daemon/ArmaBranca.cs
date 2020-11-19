using System.Daemon.Interface;

namespace System.Daemon
{
    public class ArmaBranca : IArmaBranca, IItem
    {
        public ArmaBranca(string nome, byte peso, byte valor, IDano dano, int inciativa, float alcance = 0)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
            Dano = dano;
            Iniciativa = inciativa;
            Alcance = alcance;
        }
        
        public string Nome { get; private set; }
        public byte Peso { get; private set; }
        public byte Valor { get; private set; }
        public IDano Dano { get; private set; }
        public int Iniciativa { get; private set; }
        public float Alcance { get; private set; }
    }
}