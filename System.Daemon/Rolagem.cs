using RandomGen;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class Rolagem : IRolagem
    {
        public float RolarD100()
        {
            return Convert.ToSingle(Gen.Random.Numbers.Doubles(0.0, 1.0));
        }
        public byte RolarDado(byte quantidade, byte faces, int modificador = 0)
        {
            return Convert.ToByte(Gen.Random.Numbers.Integers(quantidade, quantidade * faces)() + modificador);
        }

        
    }
}