using System;


namespace DioPooAula2.Models
{
    class Data
    {
        private int mes; //Variavel privada 
        private bool mesValido;

        public int GetMes() // metodo get
        {
            return this.mes;
        }

        public void SetMes(int mes) // validade se o mes está entre 1 a 12
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                mesValido = true;
            }

        }

        //nota: se tiver tentando acessar irá ultilziar o get, caso queira atribuir valor, usará o set
        public int Mes
        { //propriedades
            get
            {
                return this.mes; //atribuindo a propriedade variavel 
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }

            }
        }

        public void ApresentarMes() //metodo para apresentar o mes
        {
            if (mesValido == true)
            {
                Console.WriteLine(this.mes);
            }
            else
                Console.WriteLine("MÊs invalido");
        }

    }
}
