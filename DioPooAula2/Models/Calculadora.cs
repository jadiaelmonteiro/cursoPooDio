using System;

namespace DioPooAula2.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora(); //delegate

        //public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y) //metdodo
        {
            Console.WriteLine($"Soma é {x + y}");
            
        }

        public static void Subtrair(int x, int y) //metodo
        {
            Console.WriteLine($"Subtração é {x - y}");
        }
    }
}
