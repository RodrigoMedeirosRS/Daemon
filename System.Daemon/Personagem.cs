using System;
using System.Daemon.Utils;
using System.Daemon.Interface;
using System.Collections.Generic;

namespace System.Daemon
{
    public class Personagem : Rolagem, IPersonagem
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
        public List<IPericia> Pericias { get; set; }
        public List<IPericiaComArmas> PericiaComArmas { get; set; }
        public IInventario Inventario { get; set; }
        public List<IAtributo> Atributos 
        { 
            get 
            {
                var atributos = Atributos;
                var penalidades = ObterPenalidades();

                atributos[(int)NomeAtributo.Agilidade].Valor -= penalidades;
                atributos[(int)NomeAtributo.Destreza].Valor -= penalidades;

                return atributos;
            }
        }
        public byte Iniciativa 
        { 
            get
            {
                return Convert.ToByte(Atributos[(int)NomeAtributo.Agilidade].Valor + RolarDado(1, 10));
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
                var soma = Atributos[(int)NomeAtributo.Forca].Valor + Atributos[(int)NomeAtributo.Constituicao].Valor;
                var total = Convert.ToByte(Utils.Utils.IsPair(soma) ? (soma/2) + Nivel : ((soma + 1) /2) + Nivel);
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
                
                return ip > BonusIP ? ip : BonusIP;
            }
        }

        public byte BonusIP { get; set; }

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

        private byte ObterPenalidades()
        {
            byte penalidades = 0;

                foreach(var armaduras in Inventario.ArmaduraEquipada)
                    if (!armaduras.Escudo)
                        penalidades -= armaduras.IP;
            
            return penalidades;
        }
    }
}