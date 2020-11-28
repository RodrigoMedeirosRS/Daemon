using System.Daemon.Utils;
using System.Daemon.Interface;

namespace System.Daemon
{
    public class BonusForca : IBonusDeForca
    {
        public byte ModificadorDeDano(Personagem personagem)
        {
            return Convert.ToByte(ObterFaixa(personagem) -1);
        }
        
        public int[] CapacidadeDeCarga(Personagem personagem)
        {
            switch(ObterFaixa(personagem))
            {
                case(1):
                    return new int[2]{ 30, 15 };
                case(2):
                    return new int[2]{ 40, 20 };
                case(3):
                    return new int[2]{ 80, 40 };
                case(4):
                    return new int[2]{ 140, 70 };
                case(5):
                    return new int[2]{ 160, 80 };
                case(6):
                    return new int[2]{ 200, 100 };
                case(7):
                    return new int[2]{ 250, 125 };
                case(8):
                    return new int[2]{ 320, 160 };
                case(9):
                    return new int[2]{ 400, 200 };
                case(10):
                    return new int[2]{ 500, 250 };
                default:
                    return new int[2]{ 620, 310 };
            }
        }

        private byte ObterFaixa(Personagem personagem)
        {
            var forca = personagem.Atributos[(int)NomeAtributo.Forca].Valor;

            if (forca <= 3)
                return 1;
            if (forca == 4)
                return 2;
            if (forca >= 5 || forca <= 8)
                return 3;
            if (forca >= 9 || forca <= 14)
                return 4;
            else
            {
                forca -= 14;
                return Utils.Utils.IsPair(forca) ? Convert.ToByte((forca / 2) + 4) : Convert.ToByte(((forca + 1) /2) + 4); 
            }
        }
    }
}