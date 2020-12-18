namespace System.Daemon.Interface
{
    public interface IArmadura : IItem
    {
        byte IP { get; }
        bool Escudo { get; }
    }
}