using System;

namespace Definiciones
{
class Program
    {
        static void Main(string[] args)
        {
           const int puertas = 20, ventanas = 10;
           int casa = 2, t_puertas, t_ventanas;

           t_puertas = puertas * casa;
           t_ventanas = ventanas * casa;

           Console.WriteLine("Puertas: {0} Ventanas: {1}", t_puertas, t_ventanas);

           if(t_puertas < t_ventanas){
               Console.WriteLine("Hay mas ventanas que puertas en la casa");
           }else if(t_puertas > t_ventanas){
               Console.WriteLine("Hay mas puertas que ventanas en la casa");
           }else{
               Console.WriteLine("Hay el mismo numero de puertas y ventanas");
           }
        }
    }
}
