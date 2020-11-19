namespace System.Daemon.Interface
{
    public interface IItem
    {
        string Nome { get; }
        byte Peso { get; }
        byte Valor { get; }
    }
}