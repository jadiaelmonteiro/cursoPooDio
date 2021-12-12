using System;

namespace DioPooAula2.Models
{
    class Aluno : Pessoa
    {
        //herança da classe pessoa, seguindo o padrão
        public Aluno(string nome, string sobrenome, string disciplina) : base (nome, sobrenome) 
        {
            Console.WriteLine("Construtor Classe Aluno");
        }
    }
}
