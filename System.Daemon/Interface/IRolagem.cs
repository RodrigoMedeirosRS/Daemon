namespace System.Daemon.Interface
{
    public interface IRolagem
    {
        float RolarD100();
        byte RolarDado(byte quantidade, byte faces, int modificador);
    }
}