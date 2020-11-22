using System;
using System.Daemon.Utils;
using System.Daemon.Interface;
using System.Collections.Generic;

namespace System.Daemon
{
    public class Personagem : IPersonagem
    {
        public Personagem(ICabecalho descricaoDoPersonagem)
        {
            Nivel = 0;
            Descricao = descricaoDoPersonagem;
            Pericias = new List<IPericia>();
            PericiaComArmas = new List<IPericiaComArmas>();
            Inventario = new Inventario((byte)4);
            PopularAtributos();
        }
        public byte Nivel { get; private set; }
        public ICabecalho Descricao { get; set; }
        public List<IAtributo> Atributos { get; private set; }
        public List<IPericia> Pericias { get; set; }
        public List<IPericiaComArmas> PericiaComArmas { get; set; }
        public IInventario Inventario { get; set; }
        public int Iniciativa 
        { 
            get
            {
                var penalidades = Inventario.ArmaEquipada != null ? Inventario.ArmaEquipada.Iniciativa : 0;

                foreach(var armaduras in Inventario.ArmaduraEquipada)
                    penalidades += armaduras.PenalidadeAgilidade;

                return Atributos[(int)NomeAtributo.Agilidade].Valor + penalidades;
            }
        }
        private byte _pontosDeVida { get; set; }
        public byte PontosDeVida 
        {
            get
            {
                return _pontosDeVida;
            }

            set
            {
                var total = Convert.ToByte(((Atributos[(int)NomeAtributo.Forca].Valor + 
                    Atributos[(int)NomeAtributo.Constituicao].Valor) / 2) + Nivel);
                    
                _pontosDeVida = value < total ? value : total; 
            }
        }

        private byte _pontosDeMagia { get; set; }
        public byte PontosDeMagia 
        {
            get
            {
                return _pontosDeMagia;
            }

            set
            {
                var total = Convert.ToByte(2 + Nivel);                   
                _pontosDeVida = value < total ? value : total; 
            }
        }
        public byte IP { 
            get
            {
                var ip = (byte)0;

                foreach(var armaduras in Inventario.ArmaduraEquipada)
                    ip += armaduras.IP;
                
                return ip;
            }
        }

        public byte Sorte
        {
            get
            {
                return Convert.ToByte(Atributos[(int)NomeAtributo.Carisma].Valor * 2);
            }
        } 

        private void PopularAtributos()
        {
            foreach (var atributo in EnumUtils.GetValues<NomeAtributo>())
                Atributos.Add(new Atributo(atributo));
        }
    }
}