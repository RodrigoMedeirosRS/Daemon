namespace System.Daemon.Interface
{
    public interface IBonusDeForca
    {
        byte ModificadorDeDano(Personagem personagem);
        int[] CapacidadeDeCarga(Personagem personagem);
    }
}