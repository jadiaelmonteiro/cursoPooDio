using DioPooAula2.Models;
using System;

namespace DioPooAula2
{
    class Program
    {
        public delegate void Operacao(int x, int y);//DELEGATE parametros iguais aos da Calculadora

        static void Main(string[] args)
        {

           //Operacao op = Calculadora.Somar; pode ser feito sem o new.
            Operacao op = new Operacao(Calculadora.Somar); // chamando metodo calculadora.somar, atraves do delegate
            op += Calculadora.Subtrair; // muliinvoke chamando mais um metodo sem perder as informações anteriores
            op.Invoke(20, 10); //ordem fifo (primeiro o somar e depois o subtrair (ordem de fila)

            //const double Pi = 1.13; //constante seu valor não pode ser alterado
            //Console.WriteLine(Pi); 

            ////Pessoa p2 = new Pessoa();
            //Pessoa p1 = new Pessoa("Jadiael", "Monteiro");
            //p1.Apresentar();

            //Log log = Log.GetInstance();

            //log.PropriedadeLog = "Teste Instância.";

            //Log log2 = Log.GetInstance();

            //Console.WriteLine(log2.PropriedadeLog);

            //Aluno a = new Aluno("Jadiael", "Monteiro", "Poo");

            //Console.WriteLine("Digite um mÊs do ano de 01 a 12");

            //Data d = new Data();
            //int date;
            //date = int.Parse(Console.Readline());
            //d.setmes(date);

            //d.apresentarmes();

            //d.mes = 12;

        }
    }
}
