using System.Daemon.Interface;

namespace System.Daemon
{
    public class Item : IItem
    {
        public Item(string nome, byte peso, byte valor)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
        }
        public string Nome { get; private set; }
        public byte Peso { get; private set; }
        public byte Valor { get; private set; }
    }
}