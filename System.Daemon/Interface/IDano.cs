namespace System.Daemon.Interface
{
    public interface IDano
    {
        byte Dado { get; }
        byte Quantidade { get; }
        byte Modificador { get; }
        byte Bonus { get; set; }
        byte RolarDano(byte ip);
    }
}