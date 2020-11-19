using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Cabecalho : ICabecalho
    {
        public Cabecalho()
        {

        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string LocalDeNascimento { get; set; }
        public Genero Sexo { get; set; }
        public byte IdadeAparente { get; set; }
        public byte IdadeReal { get; set; }
    }
}