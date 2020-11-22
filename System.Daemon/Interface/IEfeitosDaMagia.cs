namespace System.Daemon.Interface
{
    public interface IEfeitosDaMagia
    {
        byte AumentoDeAtributo(byte circulo);
        byte AumentoDeDano(byte circulo);
        byte Protecao(byte circulo);
        Dano DanoDireto(byte circulo);
        byte Custo(byte circulo);
    }
}