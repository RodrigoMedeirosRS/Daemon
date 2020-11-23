using System.ComponentModel;
namespace System.Daemon.Utils
{
    public enum NomeAtributo
    {
        Constituicao,
        Forca,
        Destreza,
        Agilidade,
        Inteligencia,
        Vontade,
        Percepcao,
        Carisma
    }

    public enum Genero
    {
        Masculino,
        Feminino
    }

    public enum Dificuldade
    {
        Facil,
        Normal,
        Dificil
    }

    public enum TipoEfeitoMagico
    {
        AlteracaoDeAtributo,
        AumentoDeDano,
        DanoDireto,
        Protecao
    }

    public enum Caminho
    {
        Arkanun = -5,
        Spiritum = -4,
        Humano = -3, 
        Animal = -2,
        Planta = -1,
        Metamagia = 0,
        Fogo = 1,
        Agua = 2,
        Ar = 3,
        Terra = 4,
        Luz = 5,
        Trevas = 6
    }
}