using System.Collections.Generic;

namespace System.Daemon.Interface
{
    public interface IInventario
    {
        void Adicionar(IItem item);
        void Remover(IItem item);
        void Equipar(IItem item);
        void Equipar(IArma item);
        void Equipar(IArmadura item);
        void Desequipar(Item item);
        void Desequipar(IArma item);
        void Desequipar(IArmadura item);
        byte LimiteUsoRapido { get; set; }
        List<IItem> Itens { get; }
        List<IItem> UsoRapido { get; }
        List<IArmadura> ArmaduraEquipada { get; }
        IArma ArmaEquipada { get; }
        
    }
}