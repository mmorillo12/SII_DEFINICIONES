using System;

namespace Definiciones
{
    public abstract class Perro{
        protected string raza;
        protected string nombre;
        protected string color;
        public Perro(string raza, string nombre, string color){
            this.raza = raza;
            this.nombre = nombre;
            this.color = color;
        }
        public virtual void DescripcionDelAnimal(){

        }
    }
        public class Husky : Perro{
            public Husky(string raza, string nombre, string color):base(raza, nombre, color){}
        public override void DescripcionDelAnimal()
        {
            Console.WriteLine("\nLa raza del perro es: {0}", raza);
            Console.WriteLine("El nombre del perro es: {0}", nombre);
            Console.WriteLine("El color del perro es: {0}\n", color);
        }
        }

        public class Chihuahua : Perro{
            public Chihuahua(string raza, string nombre, string color):base(raza, nombre, color){}
        public override void DescripcionDelAnimal()
        {
            Console.WriteLine("La raza del perro es: {0}", raza);
            Console.WriteLine("El nombre del perro es: {0}", nombre);
            Console.WriteLine("El color del perro es: {0}\n", color);
        }
        }
        
        public class Perrera{
            public void Mostrar(){
                Husky h = new Husky("Husky", "Coronel", "Blanco y Negro");
                Chihuahua c = new Chihuahua("Chihuahua", "Cerafina", "Marron Claro");
                h.DescripcionDelAnimal();
                c.DescripcionDelAnimal();
            }
        }
class Program
    {
        static void Main(string[] args)
        {
            Perrera p = new Perrera();
            p.Mostrar();
        }
    }
}
