namespace System.Daemon.Interface
{
    public interface IAprimoramento
    {
        sbyte Custo { get; }
        void Effect<T>(T alvo);
    }
}