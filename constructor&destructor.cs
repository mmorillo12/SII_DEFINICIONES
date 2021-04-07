using System;

namespace Definiciones
{
    class Ventana{
        int ancho;
        int alto;
        string lugar;
        bool estado;
        
        public Ventana(int alto, string lugar, bool estado){
            this.alto = alto;
            this.lugar = lugar;
            this.estado = estado;
        }
        ~Ventana(){
            //Liberar y Cerrar
        }
        public void Mostrar(){
            Console.WriteLine("El alto de la ventana es {0}", alto);
            Console.WriteLine("La ventana esta en la {0}", lugar);
            Console.WriteLine("La ventana esta abierta?: {0}", estado);
        }
    }
    
class Program
    {
        static void Main(string[] args)
        {
           Ventana v = new Ventana(20, "Sala", true);
           v.Mostrar();
        }
    }
}
