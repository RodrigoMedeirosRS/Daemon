using System.Collections.Generic;

namespace System.Daemon.Interface
{
    public interface IPersonagem
    {
        byte Nivel { get; }
        ICabecalho Descricao { get; set; }
        List<IAtributo> Atributos { get; }
        List<IPericia> Pericias { get; set; }
        List<IPericiaComArmas> PericiaComArmas { get; set; }
        IInventario Inventario { get; set; }
        byte PontosDeVida { get; set; }
        byte PontosDeMagia { get; set; }
        byte Iniciativa { get; }
        byte IP { get; }
        byte BonusIP { get; set; }
        byte Sorte { get; }
    }
}