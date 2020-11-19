using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Atributo : IAtributo
    {
        public Atributo(NomeAtributo nome, byte valor = 0, int modificador = 0)
        {
            Nome = nome;
            Valor = valor;
            Modificador = modificador;
        }
        public NomeAtributo Nome { get; private set; }
        public byte Valor { get; set; }      
        public int Modificador { get; set; } 
        public float Teste 
        { 
            get
            {
                return ((Valor + Modificador) * 4) * 0.01f;
            } 
        }       
        public string Porcentagem 
        { 
            get
            {
                return ((Valor + Modificador) * 4) + "%";
            }
        }
    }
}