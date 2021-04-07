using System;

namespace Definiciones
{
    class Triangulo{
        double Base;
        double altura;

        public double Bases{get => Base; set => Base = value;}
        public double Altura{get => altura; set => altura = value;}
       public double Area(){
           return (Base*Altura)/2;
       }
}
    
class Program
    {
        static void Main(string[] args)
        {
           Triangulo t = new Triangulo();
           t.Altura = 13;
           t.Bases = 18;
           Console.WriteLine("El Area del triangulo es {0}",t.Area());
        }
    }
}
