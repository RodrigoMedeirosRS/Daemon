using System.Linq;
using System.Collections.Generic;
using System.Daemon.Interface;
using System.Daemon.Utils;

namespace System.Daemon
{
    public class Inventario : IInventario
    {
        public Inventario(byte limiteUsoRapido)
        {
            LimiteUsoRapido = limiteUsoRapido;
            Itens = new List<IItem>();
            UsoRapido = new List<IItem>();
            ArmaduraEquipada = new List<IArmadura>();
            ArmaEquipada = null;
        }

        public byte LimiteUsoRapido { get; set; }
        public List<IItem> Itens { get; private set; }
        public List<IItem> UsoRapido { get; private set; }
        public List<IArmadura>  ArmaduraEquipada { get; private set; }
        public IArma ArmaEquipada { get; private set; }

        public void Adicionar(IItem item)
        {
            Itens.Add(item);
        }
        public void Remover(IItem item)
        {
            ValidarPosseDeItem(item);
            Itens.Remove(item);
        }
        public void Equipar(IItem item)
        {
            if (UsoRapido.Count == LimiteUsoRapido)
                throw new RuleException("Você já equipou todos os " + LimiteUsoRapido +" itens.");
            Remover(item);
            UsoRapido.Add(item);
        }
        public void Equipar(IArma item)
        {
            ValidarArmaDuasMaos(false);
            Remover(item);
            ArmaEquipada = item;
        }

        public void Equipar(IArmadura item)
        {
            ValidarArmaduraEquipada(item);
            ValidarArmaDuasMaos(item.Escudo);
            Remover(item);
            ArmaduraEquipada.Add(item);
        }

        public void Desequipar(Item item)
        {
            if (UsoRapido.Count(i => i == item) == 0)
                throw new RuleException("Você não esta equipando o item " + item.Nome);
            
            UsoRapido.Remove(item);
            Adicionar(item);
        }
        public void Desequipar(IArma item)
        {
            if (ArmaduraEquipada == item)
                throw new RuleException("Você não esta equipando a arma "  + item.Nome);
            
            ArmaduraEquipada = null;
            Adicionar(item);
        }
        public void Desequipar(IArmadura item)
        {
            if (ArmaduraEquipada.Count(i => i == item) == 0)
                throw new RuleException("Você não esta equipando a armadura " + item.Nome);
            
            UsoRapido.Remove(item);
            Adicionar(item);
        }

        private void ValidarPosseDeItem(IItem item)
        {
            if (Itens.Count(i => i.Nome == item.Nome) <= 0)
                throw new RuleException("Você não possui esse equipamento");
        }

        private void ValidarArmaduraEquipada(IArmadura item)
        {
            if (ArmaduraEquipada.Count(i => i.Escudo == item.Escudo) > 0)
                throw new RuleException("Você já tem esse tipo de armadura equipada");
        }

        private void ValidarArmaDuasMaos(bool escudo)
        {
            if ((escudo && ArmaEquipada.DuasMaos) || 
                (!escudo && ArmaduraEquipada.Count(i => i.Escudo == true) > 0))
                    throw new RuleException("Você já está com as duas mãos em uso");
        }
    }
}