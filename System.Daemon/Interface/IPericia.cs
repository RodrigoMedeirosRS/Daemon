namespace System.Daemon.Interface
{
    public interface IPericia
    {
        string Nome { get; }
        byte Valor { get; }
        byte Incremento { get; set; }
        float Teste { get; }
        IAtributo AtributoBase { get; }
        IPericia Limitador { get; }
        void VincularPericia(IAtributo atributoBase = null, IPericia limitador = null, byte incremento = 0);
    }
}