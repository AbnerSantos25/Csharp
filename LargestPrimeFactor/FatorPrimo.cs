using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
     public static class FatorPrimo
     {
        public static int MaiorFatorPrimo(long numero)
        {
            int fator = 2;
            while (numero > 1)
            {
                if (numero % fator == 0)
                {
                    numero /= fator;
                }
                else
                {
                    fator++;
                }
            }
            return fator;
        }
    }
}
