namespace System.Daemon.Interface
{
    public interface IEfeitosDaMagia
    {
        byte AlteracaoDeAtributo(byte circulo);
        byte AumentoDeDano(byte circulo);
        byte Protecao(byte circulo);
        Dano DanoDireto(byte circulo);
    }
}