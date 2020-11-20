namespace System.Daemon.Interface
{
    public interface IPericiaComArmas
    {
        string Nome { get; }
        IPericia Ataque { get; }
        IPericia Defesa { get; }   
    }
}