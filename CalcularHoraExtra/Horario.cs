namespace CalcularHoraExtra
{
    public partial class Program
    {
        public class Horario
        {
            public int Hora;
            public int Minuto;
      

            public Horario(int _hora, int _minuto)
            {
                Hora = _hora;
                Minuto = _minuto;
            }
      
            public static Horario operator +(Horario a, Horario b)
            {
                int Minuto = a.Minuto + b.Minuto;
                int Hora = a.Hora + b.Hora;

                while(Minuto >= 60)
                {
                    Hora++;
                    Minuto -= 60;
                }
                return new Horario(Hora, Minuto);

            }

            public static bool operator >(Horario a, Horario b)
            {
                if(a.Hora > b.Hora)
                {
                    return true;
                }
                else if(a.Hora == b.Hora)
                {
                    if(a.Minuto > b.Minuto)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static bool operator < (Horario a, Horario b)
            {
                if(a.Hora < b.Hora)
                {
                    return true;
                }
                else if(a.Hora == b.Hora)
                {
                    if(a.Minuto <= b.Minuto)
                    {
                        return true;
                    }
                }
                return false; 
            }

            public override string ToString()
            {
                return Hora.ToString("00") + ":" + Minuto.ToString("00");
            }
            public static Horario operator -(Horario a, Horario b)
            {
                if (a > b)
                {
                    int m = 0, h = 0;
                    h = a.Hora - b.Hora;

                    if (a.Minuto >= b.Minuto)
                    {
                        m = a.Minuto - b.Minuto;
                    }
                    else
                    {
                        h--;
                        m = 60 + a.Minuto - b.Minuto;
                    }
                    return new Horario(h, m);
                }
                else if (a < b)
                {
                    int m = 0, h = 0;
                    h = b.Hora - a.Hora;

                    if (b.Minuto > a.Minuto)
                    {
                        m = b.Minuto - a.Minuto;
                    }
                    else
                    {
                        h--;
                        m = 60 + b.Minuto - a.Minuto;
                    }
                    return new Horario(h, m);
                }
                else
                    return new Horario(0, 0);
            }



        }

    }

}
