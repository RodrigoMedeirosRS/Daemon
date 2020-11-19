namespace System.Daemon.Interface
{
    public interface IArmaBranca
    {
        IDano Dano { get; }
        int Iniciativa { get; }
        float Alcance { get; }
    }
}