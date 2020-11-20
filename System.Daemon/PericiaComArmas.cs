using System.Daemon.Interface;

namespace System.Daemon
{
    public class PericiaComArmas : IPericiaComArmas
    {
        public PericiaComArmas(string nome, IPericia ataque, IPericia defesa)
        {
            Nome = nome;
            Ataque = ataque;
            Defesa = defesa;
        }
        
        public string Nome { get; private set; }
        public IPericia Ataque { get; private set; }
        public IPericia Defesa { get; private set; } 
    }
}