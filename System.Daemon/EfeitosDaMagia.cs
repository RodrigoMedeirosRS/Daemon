using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class EfeitosDaMagia : Rolagem, IEfeitosDaMagia
    {
        public byte AlteracaoDeAtributo(byte circulo)
        {
            return Convert.ToByte(circulo * 2);
        }
        public byte AumentoDeDano(byte circulo)
        {
            if (circulo > 3)
                return circulo;
            if (circulo == 3)
                return RolarDado(1,6);
            if (circulo == 4)
                return RolarDado(1,6,2);
            if (circulo == 5)
                return RolarDado(2,6);
            if (circulo == 6)
                return RolarDado(1,6,2);
            if (circulo == 7)
                return RolarDado(3,6);
            if (circulo == 8)
                return RolarDado(3,6,2);

            throw new RuleException("Circulo de magia invalido");    
        }
        public byte Protecao(byte circulo)
        {
            return circulo;
        }
        public Dano DanoDireto(byte circulo)
        {
            if (circulo == 1)
                return new Dano(0,0,2);
            if (circulo == 2)
                return new Dano(1,6);
            if (circulo == 3)
                return new Dano(1,6,2);
            if (circulo >= 4)
            { 
                return new Dano(Convert.ToByte(circulo - 2), 6, 0);
            }
            throw new RuleException("Circulo de magia invalido");
        }
    }
}