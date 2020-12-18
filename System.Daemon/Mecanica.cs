using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Mecanica : Rolagem, IMecanica
    {
        public bool Teste(float valor, Dificuldade dificuldade = Dificuldade.Normal)
        {
            var rolagem = RolarD100();
            return (rolagem >= 95) ? false : (rolagem <= ObterValorDaRolagem(valor, dificuldade));          
        }
        public bool TesteResistido(float valorAtivo, float valorPassivo)
        {
            return Teste((valorAtivo + 0.5f) - valorPassivo);
        }
        public bool TesteAuxiliado(float valor, float valorAuxiliar)
        {
            return Teste((valor + valorAuxiliar) * 0.5f);
        }

        private float ObterValorDaRolagem(float valor, Dificuldade dificuldade)
        {
            switch (dificuldade)
            {
                case (Dificuldade.Facil):
                    return (valor * 2);
                case (Dificuldade.Dificil):
                    return (valor * 0.5f);
                default:
                    return valor;
            };
        }
    }
}