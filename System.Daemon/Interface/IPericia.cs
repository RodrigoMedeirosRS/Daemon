namespace System.Daemon.Interface
{
    public interface IPericia
    {
        string Nome { get; }
        byte Valor { get; }
        byte Incremento { get; set; }
        IAtributo AtributoBase { get; }
        IPericia Limitador { get; }
    }
}