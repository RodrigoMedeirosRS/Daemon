using System.Collections.Generic;

namespace System.Daemon.Interface
{
    public interface IPersonagem
    {
        byte Nivel { get; }
        ICabecalho Descricao { get; set; }
        List<IAtributo> Atributos { get; }
        byte PontosDeVida { get; set; }
        byte PontosDeMagia { get; set; }
        int Iniciativa { get; }
        byte IP { get; }
        byte Sorte { get; }
    }
}