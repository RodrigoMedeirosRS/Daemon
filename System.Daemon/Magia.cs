using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Magia : EfeitosDaMagia, IMagia
    {
        public virtual byte Conjurar(TipoEfeitoMagico efeito, byte circulo, IPersonagem invocador, IPersonagem alvo, NomeAtributo nomeAtributo = 0, bool aumentarAtributo = true, TipoDispercao tipoDispercao = TipoDispercao.Alcance)
        {
            ValidarMagia(circulo, invocador);

            invocador.PontosDeMagia -= circulo;

            switch(efeito)
            {
                case(TipoEfeitoMagico.AlteracaoDeAtributo):
                    alvo.Atributos[(int)nomeAtributo].Modificador += aumentarAtributo ? AlteracaoDeAtributo(circulo) : -AlteracaoDeAtributo(circulo);
                    break;
                case(TipoEfeitoMagico.AumentoDeDano):
                    alvo.Inventario.ArmaEquipada.Dano.Bonus += AumentoDeDano(circulo);
                    break;
                case(TipoEfeitoMagico.DanoDireto):
                    alvo.PontosDeVida -= Convert.ToByte(DanoDireto(circulo));
                    break;
                case(TipoEfeitoMagico.Protecao):
                    alvo.BonusIP = Protecao(circulo);
                    break;
            }

            return RolarDado(circulo,6);
        }

        private void ValidarMagia(byte circulo, IPersonagem invocador)
        {          
            if (circulo > 8)
                throw new RuleException("O circulo máximo de uma magia é 8.");

            if (invocador.PontosDeMagia < circulo)
                throw new RuleException("Não há pontos de magia suficientes para esta conjuração.");
        }
    }
}