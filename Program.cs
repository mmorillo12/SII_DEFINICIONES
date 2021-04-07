using System;

namespace Definiciones
{
    public class ClaseA{
    public ClaseA(){
        Console.WriteLine("Que bello es vivir");
    }
}
public class ClaseB : ClaseA{
    public ClaseB(){
        Console.WriteLine("La vida es corta aprovechala");
    }
}
public class ClaseC : ClaseB{
    public ClaseC(){
        Console.WriteLine("Aprovechemos el tiempo");
    }
}
class Program
    {
        static void Main(string[] args)
        {
            ClaseC c = new ClaseC();
        }
    }
}
