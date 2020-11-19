namespace System.Daemon.Interface
{
    public interface IArmaDeFogo
    {
        IDano Dano { get; }
        Byte Pente { get; }
        Byte Cadencia { get; }
        float Alcance { get; }
    }
}