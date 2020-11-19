using System;
using System.Daemon.Utils;
using System.Daemon.Interface;
using System.Collections.Generic;

namespace System.Daemon
{
    public class Personagem : IPersonagem
    {
        public Personagem()
        {
            Nivel = 0;
            Descricao = new Cabecalho();
            Pericias = new List<IPericia>();
            PericiaComArmas = new List<IPericiaComArmas>();
            PopularAtributos();
        }
        public byte Nivel { get; private set; }
        public ICabecalho Descricao { get; set; }
        public List<IAtributo> Atributos { get; private set; }
        public List<IPericia> Pericias { get; set; }
        public List<IPericiaComArmas> PericiaComArmas { get; set; }
        public byte Iniciativa 
        { 
            get
            { 
                return Atributos[(int)NomeAtributo.Agilidade].Valor;
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
        public byte IP { get; private set; } 

        private void PopularAtributos()
        {
            foreach (var atributo in EnumUtils.GetValues<NomeAtributo>())
                Atributos.Add(new Atributo(atributo));
        }
    }
}