using System.Daemon.Utils;
using System.Collections.Generic;

namespace System.Daemon.Interface
{
    public interface IMagia
    {
        void Conjurar(List<Caminho> caminhos, TipoEfeitoMagico efeito, byte circulo, IPersonagem invocador, IPersonagem alvo, NomeAtributo nomeAtributo = 0, bool aumentarAtributo = true);
    }
}