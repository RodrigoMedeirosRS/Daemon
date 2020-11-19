using System.Daemon.Interface;

namespace System.Daemon
{
    public class PericiaComArmas : IPericiaComArmas
    {
        public PericiaComArmas(IPericia ataque, IPericia defesa)
        {
            Ataque = ataque;
            Defesa = defesa;
        }
        
        public IPericia Ataque { get; }
        public IPericia Defesa { get; } 
    }
}