namespace System.Daemon.Interface
{
    public interface IArma : IItem
    {
        IDano Dano { get; }
        float Alcance { get; }
        bool DuasMaos { get; }
    }
}