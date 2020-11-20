namespace System.Daemon.Interface
{
    public interface IRolagem
    {
        float RolarD100();
        int RolarDado(byte quantidade, byte faces, int modificador);
    }
}