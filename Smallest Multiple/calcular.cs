using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Multiple
{
    public static class calcular
    {
        public static long Calcular()
        {
            long i = 1;
            long res = 0;
            int num = 1;
            while (true)
            {
                while(num <= 13)
                {
                    long teste = i % num;
                    if(teste == 0)
                    {
                        Console.WriteLine($"{i} / {num} = {teste}");
                        if(num == 13)
                        {
                            res = i;
                            break;
                        }
                        num++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                i++;
                num = 1;
                if (res > 0)
                {
                    return res;
                }
            }
        }
    }
}
