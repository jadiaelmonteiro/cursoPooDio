using System;

namespace DioPooAula2.Models
{
    class Pessoa
    {
        private readonly string nome; //somente leitura, só pode ser alterado pelos construtores da propria classe
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;

        }
         
        public Pessoa(string nome, string sobrenome) //construtor da classe pessoa
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor Classe Pessoa");
            
        }

        public void Apresentar()
        {
            
            System.Console.WriteLine($"Meu nome é {nome} {sobrenome}.");
        }
    }
}
