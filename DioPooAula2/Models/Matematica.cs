using System;


namespace DioPooAula2.Models
{
    class Matematica
    {
        //Propriedades
        public int X { get; set; }
        public int Y { get; set; }

        //Construtores
        public Matematica(int x, int y)
        {
            X = x;
            Y = y;
            Calculadora.EventoCalculadora += EventHandler; //inscrevendo o metodo Eventhandler no evento
        }

        //metodo
        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Metodo executado.");
        }
    }
}
