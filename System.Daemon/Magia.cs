using System.Linq;
using System.Daemon.Utils;
using System.Daemon.Interface;
using System.Collections.Generic;

namespace System.Daemon
{
    public class Magia : EfeitosDaMagia, IMagia
    {
        public virtual byte Conjurar(List<Caminho> caminhos, TipoEfeitoMagico efeito, byte circulo, IPersonagem invocador, IPersonagem alvo, NomeAtributo nomeAtributo = 0, bool aumentarAtributo = true, TipoDispercao tipoDispercao = TipoDispercao.Alcance)
        {
            ValidarMagia(caminhos, circulo, invocador);

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

        private void ValidarMagia(List<Caminho> caminhos, byte circulo, IPersonagem invocador)
        {
            if (caminhos.Count > 2)
                throw new RuleException("Só é permitda a combinação de até 2 caminhos elementais.");
            
            if (caminhos.Count(cam => cam <= Caminho.Metamagia) > 0 && caminhos.Count > 1)
                throw new RuleException("Só caminhos elementais podem ser combinados.");
            
            if (circulo > 8)
                throw new RuleException("O circulo máximo de uma magia é 8.");

            if (invocador.PontosDeMagia < circulo)
                throw new RuleException("Não há pontos de magia suficientes para esta conjuração.");
        }
    }
}