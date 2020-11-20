using System.Daemon.Interface;

namespace System.Daemon
{
    public class Arma : IArma
    {
        public Arma(string nome, byte peso, byte valor, bool duasMaos, IDano dano, int inciativa, float alcance = 0)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
            Dano = dano;
            Iniciativa = inciativa;
            Alcance = alcance;
            DuasMaos = duasMaos;
        }
        
        public string Nome { get; private set; }
        public byte Peso { get; private set; }
        public byte Valor { get; private set; }
        public bool DuasMaos { get; set; }
        public IDano Dano { get; private set; }
        public int Iniciativa { get; private set; }
        public float Alcance { get; private set; }
    }
}