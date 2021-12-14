using System;

namespace DioPooAula2.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora(); //delegate

        public static event DelegateCalculadora EventoCalculadora; //evento

        public static void Somar(int x, int y) //metdodo
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Soma é {x + y}");
                EventoCalculadora();
            }
            else
                Console.WriteLine("Nenhum inscrito.");
            
        }

        public static void Subtrair(int x, int y) //metodo
        {
            Console.WriteLine($"Subtração é {x - y}");
        }
    }
}
