using System.Daemon.Interface;

namespace System.Daemon
{
    public abstract class Aprimoramento : IAprimoramento
    {
        public Aprimoramento()
        {

        }

        public Aprimoramento(sbyte custo)
        {
            Custo = custo;
        }

        public sbyte Custo { get; set; }

        public virtual void Effect<T>(T afetado)
        {
            
        }
    }
}