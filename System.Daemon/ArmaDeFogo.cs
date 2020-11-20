using System.Daemon.Interface;

namespace System.Daemon
{
    public class ArmaDeFogo : IArmaDeFogo, IArma
    {
        public ArmaDeFogo(string nome, byte peso, byte valor, bool duasMaos, IDano dano, byte pente, byte cadencia, float alcance = 0, int iniciativa = 0)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
            Dano = dano;
            Pente = pente;
            Cadencia = cadencia;
            Alcance = alcance;
            DuasMaos = duasMaos;
            Iniciativa = iniciativa;
        }
        public string Nome { get; private set; }
        public byte Peso { get; private set; }
        public byte Valor { get; private set; }
        public bool DuasMaos { get; set; }
        public IDano Dano { get; private set; }
        public byte Pente { get; private set; }
        public byte Cadencia { get; private set; }
        public float Alcance { get; private set; }
        public int Iniciativa { get; private set; }
    }
}