using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Cabecalho : ICabecalho
    {
        public Cabecalho(string nome, string sobrenome, DateTime dataNascimento, string localDeNascimento, Genero sexo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            LocalDeNascimento = localDeNascimento;
            Sexo = sexo;
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string LocalDeNascimento { get; private set; }
        public Genero Sexo { get; private set; }
        public byte IdadeAparente { get; set; }
        public byte IdadeReal { get; set; }
    }
}