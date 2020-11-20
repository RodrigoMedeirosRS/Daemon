namespace System.Daemon.Interface
{
    public interface IArmadura : IItem
    {
        byte IP { get; }
        int PenalidadeAgilidade { get; }
        int PenalidadeDestreza { get; }
        bool Escudo { get; }
    }
}